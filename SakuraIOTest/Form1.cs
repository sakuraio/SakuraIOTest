using SakuraIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace SakuraIOTest
{


    public partial class Form1 : Form
    {
        Client client = new Client();
        List<Project> ProjectList;
        List<Module> ModuleList;

        public Form1()
        {
            InitializeComponent();
            typeBox.SelectedIndex = 0;
        }

        #region UI制御関連
        private void EnableWebSocketUIControls()
        {
            //sendButton.Enabled = true;
        }

        private void EnableAPIClientControls()
        {
            getProjectListButton.Enabled = true;
            getModuleListButton.Enabled = false;
            setTargetModuleButton.Enabled = false;
            projectModuleList.Items.Clear();
            projectModuleList.Enabled = false;
            projectListBox.Items.Clear();
            projectListBox.Enabled = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetModuleBox.Text = projectModuleList.SelectedItem.ToString();
        }

        private void setTargetModuleButton_Click(object sender, EventArgs e)
        {
            var targetModule = ModuleList[projectModuleList.SelectedIndex];
            targetModuleBox.Text = targetModule.ID;
            MessageBox.Show(string.Format("送信先モジュールIDを以下に設定しました\nID: {0}\nモジュール名: {1}", targetModule.ID, targetModule.Name),
                "送信先設定完了",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void jsonListCopyMenuItem_Click(object sender, EventArgs e)
        {
            var lv = jsonPreviewList.SelectedItems.Cast<string>().Aggregate((a, b) => string.Format("{0}, {1}", a, b));
            Clipboard.SetText(string.Format("[{0}]", lv));
        }


        private void clearRxButton_Click(object sender, EventArgs e)
        {
            csvPreviewListView.Items.Clear();
            jsonPreviewList.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new DatastoreForm();
            form.Show();
        }

        private void projectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectModuleList.Items.Clear();
            projectModuleList.Enabled = false;
            setTargetModuleButton.Enabled = false;
        }

        private void clearTxQueueButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("送信メッセージキューの内容をすべて削除しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {
                return;
            }

            txQueueListView.Items.Clear();
        }

        private void listCopyMenuItem_Click(object sender, EventArgs e)
        {
            var lv = csvPreviewListView.SelectedItems.Cast<ListViewItem>();
            try
            {
                var items = lv.Select(x => x.SubItems.Cast<ListViewSubItem>().Select(y => y.Text).Aggregate((a, b) => string.Format("{0},{1}", a, b)))
                    .Aggregate((a, b) => string.Format("{0}\n{1}", a, b));
                Clipboard.SetText(items);
            }
            catch (InvalidOperationException)
            {
                return;
            }
        }
        #endregion

        private async void websocketConnectButton_Click(object sender, EventArgs e)
        {
            if (client.IsWebSocketOpened)
            {
                // close
                await client.CloseWebSocket();
                statusLabel.Text = "接続を切断しました";
                websocketConnectButton.Text = "接続";
                return;
            }
            client.SetWebSocketToken(tokenBox.Text);
            statusLabel.Text = "接続試行中";
            try
            {
                await client.ConnectWebSocket(msg =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        // channelsメッセージを受信したらListViewに追加
                        if (channelTypeCheckBox.Checked && msg.Type == "channels")
                        {

                            jsonPreviewList.Items.Add(msg.ToString());
                            jsonPreviewList.TopIndex = jsonPreviewList.Items.Count - 1;

                            if (msg.Type == "channels")
                            {
                                var cmsg = (ChannelMessage)msg;

                                foreach (var channel in cmsg.Payload.Channels)
                                {
                                    var listItem = new ListViewItem(new string[] {
                                        channel.ChannelID.ToString(), channel.Type, channel.GetValue().ToString(), channel.Datetime });
                                    csvPreviewListView.Items.Add(listItem);
                                }

                            }
                        }
                        // TODO: ToStringで刺さるのを直す
                        //else if (keepaliveTypeCheckBox.Checked && msg.Type == "keepalive")
                        //{
                        //    jsonPreviewList.Items.Add(msg.ToString());
                        //    jsonPreviewList.TopIndex = jsonPreviewList.Items.Count - 1;
                        //}

                    });

                }, issuccessed =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        statusLabel.Text = "通信中";
                        websocketConnectButton.Text = "切断";
                        EnableWebSocketUIControls();
                    });
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WebSocket エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {

            if (!client.IsWebSocketOpened)
            {
                MessageBox.Show("\"WebSocket設定\"でWebSocketトークンを入力し、接続を行ってください",
                    "WebSocketが接続されていません",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // 送信先
            ChannelMessage channelMessage = new ChannelMessage();
            channelMessage.Module = targetModuleBox.Text;
            channelMessage.Datetime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzzz");
            channelMessage.Type = "channels";

            var channels = txQueueListView.Items.Cast<ListViewItem>()
                .Select((x) =>
                {
                    return new Channel
                    {
                        ChannelID = int.Parse(x.SubItems[0].Text),
                        Type = typeNameToIndicator(x.SubItems[1].Text),
                        Value = convertValueType(x.SubItems[1].Text, x.SubItems[2].Text),
                        Datetime = x.SubItems[3].Text
                    };
                })
                .ToList();



            channelMessage.Payload.Channels.AddRange(channels);


            statusLabel.Text = "メッセージ送信中";
            await client.SendWebSocket(channelMessage);

            statusLabel.Text = "メッセージ送信完了";
            jsonPreviewList.Items.Add("------- send message");
        }

        private async void getModuleListButton_Click(object sender, EventArgs e)
        {
            if (!CheckAPIAuthenticated())
            {
                return;
            }

            if (projectListBox.SelectedIndex == -1 || projectListBox.Items.Count == 0)
            {
                MessageBox.Show("プロジェクトが選択されていません",
                    "プロジェクトを選択してください",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var targetProject = ProjectList[projectListBox.SelectedIndex];

            statusLabel.Text = "モジュール検索中";
            ModuleList = await client.GetModulesFromProjectID(targetProject.ID);
            statusLabel.Text = "完了";
            projectModuleList.Items.Clear();
            projectModuleList.Items.AddRange(ModuleList.ToArray());
            if (ModuleList.Count() == 0)
            {
                MessageBox.Show("プロジェクトに登録されているモジュールが見つかりませんでした",
                    "プロジェクトにモジュールが登録されていません",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            projectModuleList.SelectedIndex = 0;
            projectModuleList.Enabled = true;
            setTargetModuleButton.Enabled = true;
        }

        private async void apiAuthButton_Click(object sender, EventArgs e)
        {
            try
            {
                client.SetAPIToken(apiTokenBox.Text, apiSecretBox.Text);
                await client.AuthenticateAPI();
                apiStateLabel.Text = "認証済み";
                EnableAPIClientControls();
            }
            catch
            {
                MessageBox.Show("APIの認証に失敗しました API TokenとSecretを確認してください", "API認証失敗", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private async void getProjectListButton_Click(object sender, EventArgs e)
        {
            if (!CheckAPIAuthenticated())
            {
                return;
            }

            statusLabel.Text = "プロジェクト取得中";
            client.SetAPIToken(apiTokenBox.Text, apiSecretBox.Text);

            ProjectList = await client.GetProjects();
            projectListBox.Items.Clear();
            projectListBox.Items.AddRange(ProjectList.ToArray());
            projectListBox.SelectedIndex = 0;
            projectListBox.Enabled = true;
            getModuleListButton.Enabled = true;
            projectModuleList.Enabled = false;
            setTargetModuleButton.Enabled = false;
            statusLabel.Text = "完了";
        }

        private async void autoSetupWebSocketTokenButton_Click(object sender, EventArgs e)
        {
            if (!CheckAPIAuthenticated())
            {
                return;
            }

            if (ProjectList == null || ProjectList.Count() == 0)
            {
                MessageBox.Show("プロジェクトが見つかりませんでした",
                    "プロジェクトが見つかりませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("自動設定を行いますか？\n\n● 送信対象モジュールを含むプロジェクトに関連付いているWebSocket連携サービスのうち1つを自動選択し、本プログラム内で使用できるよう設定します\n● プロジェクト内にWebSocket連携サービスが含まれない場合、自動的にWebSocket連携サービスを作成します",
                "自動設定確認",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            var project = ProjectList[projectListBox.SelectedIndex];
            var websocket_services = (await client.GetServicesFromProject(project)).Where(x => x.Type == "websocket").ToList();
            if (websocket_services.Count() > 0)
            {
                // WebSocket連携サービスが見つかったので適当に選んで使う
                tokenBox.Text = websocket_services[0].Token;
                MessageBox.Show("以下の連携サービスを使用するように設定しました\n" + string.Format("名前: {0}\nToken: {1}", websocket_services[0].Name, websocket_services[0].Token));
                return;
            }

            // 連携サービスが見つからなかったので自動作成する
            var resp = await client.CreateService(project.ID, "sakura.io Testで自動設定された連携サービス", "websocket");
            tokenBox.Text = resp.Token;
            MessageBox.Show("連携サービスを作成しました\n" + $"連携サービス名: {resp.Name}\nWebSocket Token: {resp.Token}\n\n作成した連携サービスのトークンをWebSocket Token欄にコピーしました");

        }

        private void addTxDataButton_Click(object sender, EventArgs e)
        {
            // TimeSpanは100ns単位
            var datetime = DateTime.Now - new TimeSpan((long)(timeOffsetNumBox.Value) * 10000);

            if (valueBox.Text.Length == 0)
            {
                return;
            }

            switch (typeBox.SelectedText)
            {
                case "float":
                    if (!float.TryParse(valueBox.Text, out float _))
                    {
                        MessageBox.Show("valueが単精度浮動小数点数ではありません");
                        return;
                    }
                    break;
                case "double":
                    if (!double.TryParse(valueBox.Text, out double _))
                    {
                        MessageBox.Show("valueが倍精度浮動小数点数ではありません");
                        return;
                    }
                    break;
                case "int32":
                    if (!int.TryParse(valueBox.Text, out int _))
                    {
                        MessageBox.Show("valueが32bit 符号あり整数ではありません");
                        return;
                    }
                    break;
                case "uint32":
                    if (!uint.TryParse(valueBox.Text, out uint _))
                    {
                        MessageBox.Show("valueが32bit 符号なし整数ではありません");
                        return;
                    }
                    break;
                case "int64":
                    if (!long.TryParse(valueBox.Text, out long _))
                    {
                        MessageBox.Show("valueが64bit 符号あり整数ではありません");
                        return;
                    }
                    break;
                case "uint64":
                    if (!ulong.TryParse(valueBox.Text, out ulong _))
                    {
                        MessageBox.Show("valueが64bit 符号なし整数ではありません");
                        return;
                    }
                    break;
                case "byte[8]":
                    MessageBox.Show("未実装です");
                    return;
            }

            var txData = new ListViewItem(new string[] {
                channelNumBox.Value.ToString(), typeBox.Text, valueBox.Text, datetime.ToString("yyyy-MM-ddTHH:mm:ss.fffzzzz") });
            txQueueListView.Items.Add(txData);
        }

        private async void searchProjectFromWebSocketTokenButton_Click(object sender, EventArgs e)
        {
            if (!CheckAPIAuthenticated())
            {
                return;
            }

            var result = MessageBox.Show("WebSocket Tokenを基にプロジェクト検索を行いますか？",
                "自動設定確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.No)
            {
                return;
            }

            statusLabel.Text = "プロジェクト取得中";
            client.SetAPIToken(apiTokenBox.Text, apiSecretBox.Text);

            ProjectList = await client.GetProjects();
            projectListBox.Items.Clear();
            projectListBox.Items.AddRange(ProjectList.ToArray());
            projectListBox.Enabled = true;
            getModuleListButton.Enabled = true;
            projectModuleList.Enabled = false;
            setTargetModuleButton.Enabled = false;

            try
            {
                var tokenID = await client.GetProjectIDFromServiceToken(tokenBox.Text);
                var project = ProjectList.Where(x => x.ID == tokenID).Single();
                projectListBox.SelectedIndex = projectListBox.Items.IndexOf(project);
                MessageBox.Show("以下のプロジェクトが見つかりました:\n" + string.Format("{0}: {1}", project.ID, project.Name),
                    "検索完了",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                projectListBox.SelectedIndex = 0;
                MessageBox.Show("WebSocket Tokenが所属しているプロジェクトが見つかりませんでした\n以下のような問題がないか確認してもう一度試してください\n\n● WebSocket Tokenの入力ミス\n● WebSocket TokenとAPI Tokenが別アカウントのものである",
                    "WebSocket Tokenが所属しているプロジェクトが見つかりませんでした",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }

            statusLabel.Text = "完了";
        }

        #region utils

        /// <summary>
        /// APIの認証状態をチェックして認証されていなければダイアログを表示
        /// </summary>
        /// <returns>認証済みか否か</returns>
        private bool CheckAPIAuthenticated()
        {
            if (!client.IsAPIAuthenticated)
            {
                MessageBox.Show("API認証が行われていません\nAPI TokenとSecretを入力し、「認証」ボタンを押して認証を行ってから再度試してください",
                    "API認証が行われていません",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private string typeNameToIndicator(string typename)
        {
            switch (typename)
            {
                case "int32":
                    return "i";
                case "uint32":
                    return "I";
                case "int64":
                    return "l";
                case "uint64":
                    return "L";
                case "float":
                    return "f";
                case "double":
                    return "d";
            }
            return "";
        }

        private object convertValueType(string typename, object value)
        {
            switch (typename)
            {
                case "int32":
                    return Convert.ToInt32(value);
                case "uint32":
                    return Convert.ToUInt32(value);
                case "int64":
                    return Convert.ToInt64(value);
                case "uint64":
                    return Convert.ToUInt64(value);
                case "float":
                    return (float)Convert.ToDouble(value);
                case "double":
                    return Convert.ToDouble(value);
            }
            return null;
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("ブラウザでAPI Token取得ページを開きますか？\n\nトークンをまだ作成していない場合、「APIキー追加」をクリックし、権限を「全権限」に設定したトークンを作成してください。\nログインを要求された場合、sakura.ioを使用している会員IDでログインを行うと一覧が確認できます。", "トークン取得", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            System.Diagnostics.Process.Start("https://secure.sakura.ad.jp/iot/console/#/apikeys");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            apiTokenBox.Text = Properties.Settings.Default.APIToken;
            apiSecretBox.Text = Properties.Settings.Default.APISecret;
            tokenBox.Text = Properties.Settings.Default.WebSocketToken;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (apiTokenBox.Text != Properties.Settings.Default.APIToken ||
                apiSecretBox.Text != Properties.Settings.Default.APISecret ||
                tokenBox.Text != Properties.Settings.Default.WebSocketToken)
            {
                if (MessageBox.Show("トークンなどの設定情報を保存しますか？", "設定情報の保存", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Properties.Settings.Default.APIToken = apiTokenBox.Text;
                    Properties.Settings.Default.APISecret= apiSecretBox.Text;
                    Properties.Settings.Default.WebSocketToken = tokenBox.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }


}
