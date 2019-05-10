namespace SakuraIOTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.websocketConnectButton = new System.Windows.Forms.Button();
            this.jsonPreviewList = new System.Windows.Forms.ListBox();
            this.jsonMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jsonListCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.channelNumBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.targetModuleBox = new System.Windows.Forms.TextBox();
            this.getProjectListButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.apiTokenBox = new System.Windows.Forms.TextBox();
            this.apiSecretBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.projectListBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.csvPreviewListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.csvListMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csvListCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exportRxButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txQueueListView = new System.Windows.Forms.ListView();
            this.Channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportTxButton = new System.Windows.Forms.Button();
            this.importTxButton = new System.Windows.Forms.Button();
            this.clearTxQueueButton = new System.Windows.Forms.Button();
            this.timeOffsetNumBox = new System.Windows.Forms.NumericUpDown();
            this.addTxDataButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearRxButton = new System.Windows.Forms.Button();
            this.keepaliveTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.channelTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.autoSetupWebSocketTokenButton = new System.Windows.Forms.Button();
            this.searchProjectFromWebSocketTokenButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.apiStateLabel = new System.Windows.Forms.Label();
            this.projectModuleList = new System.Windows.Forms.ComboBox();
            this.getModuleListButton = new System.Windows.Forms.Button();
            this.setTargetModuleButton = new System.Windows.Forms.Button();
            this.apiAuthButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.jsonMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelNumBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.csvListMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeOffsetNumBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tokenBox
            // 
            this.tokenBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenBox.Location = new System.Drawing.Point(127, 97);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(217, 19);
            this.tokenBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "WebSocket Token";
            // 
            // websocketConnectButton
            // 
            this.websocketConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.websocketConnectButton.Location = new System.Drawing.Point(352, 95);
            this.websocketConnectButton.Name = "websocketConnectButton";
            this.websocketConnectButton.Size = new System.Drawing.Size(125, 23);
            this.websocketConnectButton.TabIndex = 2;
            this.websocketConnectButton.Text = "接続";
            this.websocketConnectButton.UseVisualStyleBackColor = true;
            this.websocketConnectButton.Click += new System.EventHandler(this.websocketConnectButton_Click);
            // 
            // jsonPreviewList
            // 
            this.jsonPreviewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonPreviewList.ContextMenuStrip = this.jsonMenuStrip1;
            this.jsonPreviewList.FormattingEnabled = true;
            this.jsonPreviewList.ItemHeight = 12;
            this.jsonPreviewList.Location = new System.Drawing.Point(0, 0);
            this.jsonPreviewList.Name = "jsonPreviewList";
            this.jsonPreviewList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.jsonPreviewList.Size = new System.Drawing.Size(597, 136);
            this.jsonPreviewList.TabIndex = 3;
            // 
            // jsonMenuStrip1
            // 
            this.jsonMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonListCopyMenuItem});
            this.jsonMenuStrip1.Name = "jsonMenuStrip1";
            this.jsonMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // jsonListCopyMenuItem
            // 
            this.jsonListCopyMenuItem.Name = "jsonListCopyMenuItem";
            this.jsonListCopyMenuItem.Size = new System.Drawing.Size(114, 22);
            this.jsonListCopyMenuItem.Text = "コピー(&C)";
            this.jsonListCopyMenuItem.Click += new System.EventHandler(this.jsonListCopyMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 17);
            this.statusLabel.Text = "未接続";
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "int32",
            "uint32",
            "int64",
            "uint64",
            "float",
            "double",
            "byte[8]"});
            this.typeBox.Location = new System.Drawing.Point(118, 216);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(308, 20);
            this.typeBox.TabIndex = 6;
            // 
            // channelNumBox
            // 
            this.channelNumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channelNumBox.Location = new System.Drawing.Point(118, 191);
            this.channelNumBox.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.channelNumBox.Name = "channelNumBox";
            this.channelNumBox.Size = new System.Drawing.Size(308, 19);
            this.channelNumBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "channel";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "type";
            // 
            // valueBox
            // 
            this.valueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueBox.Location = new System.Drawing.Point(118, 243);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(308, 19);
            this.valueBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "value";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(433, 214);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(182, 23);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "WebSocketで送信";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "送信先モジュールID";
            // 
            // targetModuleBox
            // 
            this.targetModuleBox.Location = new System.Drawing.Point(129, 18);
            this.targetModuleBox.Name = "targetModuleBox";
            this.targetModuleBox.Size = new System.Drawing.Size(188, 19);
            this.targetModuleBox.TabIndex = 14;
            // 
            // getProjectListButton
            // 
            this.getProjectListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getProjectListButton.Enabled = false;
            this.getProjectListButton.Location = new System.Drawing.Point(7, 124);
            this.getProjectListButton.Name = "getProjectListButton";
            this.getProjectListButton.Size = new System.Drawing.Size(470, 23);
            this.getProjectListButton.TabIndex = 15;
            this.getProjectListButton.Text = "プロジェクト一覧取得";
            this.getProjectListButton.UseVisualStyleBackColor = true;
            this.getProjectListButton.Click += new System.EventHandler(this.getProjectListButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "API Token";
            // 
            // apiTokenBox
            // 
            this.apiTokenBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apiTokenBox.Location = new System.Drawing.Point(79, 17);
            this.apiTokenBox.Name = "apiTokenBox";
            this.apiTokenBox.Size = new System.Drawing.Size(397, 19);
            this.apiTokenBox.TabIndex = 17;
            // 
            // apiSecretBox
            // 
            this.apiSecretBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apiSecretBox.Location = new System.Drawing.Point(79, 42);
            this.apiSecretBox.Name = "apiSecretBox";
            this.apiSecretBox.Size = new System.Drawing.Size(397, 19);
            this.apiSecretBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "Secret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "project";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "modules";
            // 
            // projectListBox
            // 
            this.projectListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectListBox.Enabled = false;
            this.projectListBox.FormattingEnabled = true;
            this.projectListBox.Location = new System.Drawing.Point(66, 153);
            this.projectListBox.Name = "projectListBox";
            this.projectListBox.Size = new System.Drawing.Size(410, 20);
            this.projectListBox.TabIndex = 23;
            this.projectListBox.SelectedIndexChanged += new System.EventHandler(this.projectListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 172);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.csvPreviewListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CSV";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // csvPreviewListView
            // 
            this.csvPreviewListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.csvPreviewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.csvPreviewListView.ContextMenuStrip = this.csvListMenuStrip1;
            this.csvPreviewListView.FullRowSelect = true;
            this.csvPreviewListView.Location = new System.Drawing.Point(0, 0);
            this.csvPreviewListView.Name = "csvPreviewListView";
            this.csvPreviewListView.Size = new System.Drawing.Size(604, 143);
            this.csvPreviewListView.TabIndex = 29;
            this.csvPreviewListView.UseCompatibleStateImageBehavior = false;
            this.csvPreviewListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Channel";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datetime";
            this.columnHeader4.Width = 179;
            // 
            // csvListMenuStrip1
            // 
            this.csvListMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvListCopyMenuItem});
            this.csvListMenuStrip1.Name = "csvListMenuStrip1";
            this.csvListMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // csvListCopyMenuItem
            // 
            this.csvListCopyMenuItem.Name = "csvListCopyMenuItem";
            this.csvListCopyMenuItem.Size = new System.Drawing.Size(114, 22);
            this.csvListCopyMenuItem.Text = "コピー(&C)";
            this.csvListCopyMenuItem.Click += new System.EventHandler(this.listCopyMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.jsonPreviewList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 146);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "JSON";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exportRxButton
            // 
            this.exportRxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportRxButton.Enabled = false;
            this.exportRxButton.Location = new System.Drawing.Point(297, 189);
            this.exportRxButton.Name = "exportRxButton";
            this.exportRxButton.Size = new System.Drawing.Size(227, 23);
            this.exportRxButton.TabIndex = 25;
            this.exportRxButton.Text = "エクスポート";
            this.exportRxButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "time offset (ms)";
            // 
            // txQueueListView
            // 
            this.txQueueListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Channel,
            this.Type,
            this.Value,
            this.Datetime});
            this.txQueueListView.FullRowSelect = true;
            this.txQueueListView.Location = new System.Drawing.Point(7, 43);
            this.txQueueListView.Name = "txQueueListView";
            this.txQueueListView.Size = new System.Drawing.Size(607, 139);
            this.txQueueListView.TabIndex = 28;
            this.txQueueListView.UseCompatibleStateImageBehavior = false;
            this.txQueueListView.View = System.Windows.Forms.View.Details;
            // 
            // Channel
            // 
            this.Channel.Text = "Channel";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // Datetime
            // 
            this.Datetime.Text = "Datetime";
            this.Datetime.Width = 203;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.exportTxButton);
            this.groupBox2.Controls.Add(this.importTxButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.targetModuleBox);
            this.groupBox2.Controls.Add(this.clearTxQueueButton);
            this.groupBox2.Controls.Add(this.sendButton);
            this.groupBox2.Controls.Add(this.timeOffsetNumBox);
            this.groupBox2.Controls.Add(this.addTxDataButton);
            this.groupBox2.Controls.Add(this.txQueueListView);
            this.groupBox2.Controls.Add(this.typeBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.channelNumBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.valueBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 294);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "送信メッセージキュー";
            // 
            // exportTxButton
            // 
            this.exportTxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportTxButton.Enabled = false;
            this.exportTxButton.Location = new System.Drawing.Point(528, 240);
            this.exportTxButton.Name = "exportTxButton";
            this.exportTxButton.Size = new System.Drawing.Size(87, 23);
            this.exportTxButton.TabIndex = 33;
            this.exportTxButton.Text = "エクスポート";
            this.exportTxButton.UseVisualStyleBackColor = true;
            // 
            // importTxButton
            // 
            this.importTxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importTxButton.Enabled = false;
            this.importTxButton.Location = new System.Drawing.Point(433, 240);
            this.importTxButton.Name = "importTxButton";
            this.importTxButton.Size = new System.Drawing.Size(87, 23);
            this.importTxButton.TabIndex = 32;
            this.importTxButton.Text = "インポート";
            this.importTxButton.UseVisualStyleBackColor = true;
            // 
            // clearTxQueueButton
            // 
            this.clearTxQueueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearTxQueueButton.Location = new System.Drawing.Point(433, 265);
            this.clearTxQueueButton.Name = "clearTxQueueButton";
            this.clearTxQueueButton.Size = new System.Drawing.Size(182, 23);
            this.clearTxQueueButton.TabIndex = 31;
            this.clearTxQueueButton.Text = "送信メッセージキューをクリア";
            this.clearTxQueueButton.UseVisualStyleBackColor = true;
            this.clearTxQueueButton.Click += new System.EventHandler(this.clearTxQueueButton_Click);
            // 
            // timeOffsetNumBox
            // 
            this.timeOffsetNumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeOffsetNumBox.Location = new System.Drawing.Point(118, 268);
            this.timeOffsetNumBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeOffsetNumBox.Name = "timeOffsetNumBox";
            this.timeOffsetNumBox.Size = new System.Drawing.Size(308, 19);
            this.timeOffsetNumBox.TabIndex = 30;
            // 
            // addTxDataButton
            // 
            this.addTxDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTxDataButton.Location = new System.Drawing.Point(433, 188);
            this.addTxDataButton.Name = "addTxDataButton";
            this.addTxDataButton.Size = new System.Drawing.Size(182, 23);
            this.addTxDataButton.TabIndex = 29;
            this.addTxDataButton.Text = "データをキューに追加";
            this.addTxDataButton.UseVisualStyleBackColor = true;
            this.addTxDataButton.Click += new System.EventHandler(this.addTxDataButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.exportRxButton);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Controls.Add(this.clearRxButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 218);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "受信したメッセージ";
            // 
            // clearRxButton
            // 
            this.clearRxButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearRxButton.Location = new System.Drawing.Point(7, 189);
            this.clearRxButton.Name = "clearRxButton";
            this.clearRxButton.Size = new System.Drawing.Size(284, 23);
            this.clearRxButton.TabIndex = 26;
            this.clearRxButton.Text = "受信データクリア";
            this.clearRxButton.UseVisualStyleBackColor = true;
            this.clearRxButton.Click += new System.EventHandler(this.clearRxButton_Click);
            // 
            // keepaliveTypeCheckBox
            // 
            this.keepaliveTypeCheckBox.AutoSize = true;
            this.keepaliveTypeCheckBox.Enabled = false;
            this.keepaliveTypeCheckBox.Location = new System.Drawing.Point(98, 326);
            this.keepaliveTypeCheckBox.Name = "keepaliveTypeCheckBox";
            this.keepaliveTypeCheckBox.Size = new System.Drawing.Size(72, 16);
            this.keepaliveTypeCheckBox.TabIndex = 41;
            this.keepaliveTypeCheckBox.Text = "keepalive";
            this.keepaliveTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 12);
            this.label12.TabIndex = 40;
            this.label12.Text = "受信対象のメッセージタイプ";
            // 
            // channelTypeCheckBox
            // 
            this.channelTypeCheckBox.AutoSize = true;
            this.channelTypeCheckBox.Checked = true;
            this.channelTypeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.channelTypeCheckBox.Enabled = false;
            this.channelTypeCheckBox.Location = new System.Drawing.Point(10, 326);
            this.channelTypeCheckBox.Name = "channelTypeCheckBox";
            this.channelTypeCheckBox.Size = new System.Drawing.Size(69, 16);
            this.channelTypeCheckBox.TabIndex = 39;
            this.channelTypeCheckBox.Text = "channels";
            this.channelTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoSetupWebSocketTokenButton
            // 
            this.autoSetupWebSocketTokenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoSetupWebSocketTokenButton.Location = new System.Drawing.Point(7, 177);
            this.autoSetupWebSocketTokenButton.Name = "autoSetupWebSocketTokenButton";
            this.autoSetupWebSocketTokenButton.Size = new System.Drawing.Size(470, 23);
            this.autoSetupWebSocketTokenButton.TabIndex = 38;
            this.autoSetupWebSocketTokenButton.Text = "WebSocket Token自動設定";
            this.autoSetupWebSocketTokenButton.UseVisualStyleBackColor = true;
            this.autoSetupWebSocketTokenButton.Click += new System.EventHandler(this.autoSetupWebSocketTokenButton_Click);
            // 
            // searchProjectFromWebSocketTokenButton
            // 
            this.searchProjectFromWebSocketTokenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProjectFromWebSocketTokenButton.Location = new System.Drawing.Point(7, 282);
            this.searchProjectFromWebSocketTokenButton.Name = "searchProjectFromWebSocketTokenButton";
            this.searchProjectFromWebSocketTokenButton.Size = new System.Drawing.Size(469, 23);
            this.searchProjectFromWebSocketTokenButton.TabIndex = 36;
            this.searchProjectFromWebSocketTokenButton.Text = "WebSocket Tokenからプロジェクト取得";
            this.searchProjectFromWebSocketTokenButton.UseVisualStyleBackColor = true;
            this.searchProjectFromWebSocketTokenButton.Click += new System.EventHandler(this.searchProjectFromWebSocketTokenButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "API state";
            // 
            // apiStateLabel
            // 
            this.apiStateLabel.AutoSize = true;
            this.apiStateLabel.Location = new System.Drawing.Point(77, 71);
            this.apiStateLabel.Name = "apiStateLabel";
            this.apiStateLabel.Size = new System.Drawing.Size(41, 12);
            this.apiStateLabel.TabIndex = 32;
            this.apiStateLabel.Text = "未認証";
            // 
            // projectModuleList
            // 
            this.projectModuleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectModuleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectModuleList.Enabled = false;
            this.projectModuleList.FormattingEnabled = true;
            this.projectModuleList.Location = new System.Drawing.Point(66, 208);
            this.projectModuleList.Name = "projectModuleList";
            this.projectModuleList.Size = new System.Drawing.Size(205, 20);
            this.projectModuleList.TabIndex = 33;
            // 
            // getModuleListButton
            // 
            this.getModuleListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getModuleListButton.Enabled = false;
            this.getModuleListButton.Location = new System.Drawing.Point(279, 206);
            this.getModuleListButton.Name = "getModuleListButton";
            this.getModuleListButton.Size = new System.Drawing.Size(198, 23);
            this.getModuleListButton.TabIndex = 34;
            this.getModuleListButton.Text = "モジュール一覧取得";
            this.getModuleListButton.UseVisualStyleBackColor = true;
            this.getModuleListButton.Click += new System.EventHandler(this.getModuleListButton_Click);
            // 
            // setTargetModuleButton
            // 
            this.setTargetModuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setTargetModuleButton.Enabled = false;
            this.setTargetModuleButton.Location = new System.Drawing.Point(7, 234);
            this.setTargetModuleButton.Name = "setTargetModuleButton";
            this.setTargetModuleButton.Size = new System.Drawing.Size(470, 23);
            this.setTargetModuleButton.TabIndex = 35;
            this.setTargetModuleButton.Text = "送信対象モジュールとして設定";
            this.setTargetModuleButton.UseVisualStyleBackColor = true;
            this.setTargetModuleButton.Click += new System.EventHandler(this.setTargetModuleButton_Click);
            // 
            // apiAuthButton
            // 
            this.apiAuthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apiAuthButton.Location = new System.Drawing.Point(390, 66);
            this.apiAuthButton.Name = "apiAuthButton";
            this.apiAuthButton.Size = new System.Drawing.Size(87, 23);
            this.apiAuthButton.TabIndex = 37;
            this.apiAuthButton.Text = "認証";
            this.apiAuthButton.UseVisualStyleBackColor = true;
            this.apiAuthButton.Click += new System.EventHandler(this.apiAuthButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.keepaliveTypeCheckBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.channelTypeCheckBox);
            this.groupBox4.Controls.Add(this.getProjectListButton);
            this.groupBox4.Controls.Add(this.tokenBox);
            this.groupBox4.Controls.Add(this.apiTokenBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.websocketConnectButton);
            this.groupBox4.Controls.Add(this.autoSetupWebSocketTokenButton);
            this.groupBox4.Controls.Add(this.searchProjectFromWebSocketTokenButton);
            this.groupBox4.Controls.Add(this.apiSecretBox);
            this.groupBox4.Controls.Add(this.apiAuthButton);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.setTargetModuleButton);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.getModuleListButton);
            this.groupBox4.Controls.Add(this.projectListBox);
            this.groupBox4.Controls.Add(this.projectModuleList);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.apiStateLabel);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(491, 518);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "API関連設定";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(9, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Datastore tools";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(14, 12);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2MinSize = 0;
            this.splitContainer2.Size = new System.Drawing.Size(1148, 524);
            this.splitContainer2.SplitterDistance = 505;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 42;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(273, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 12);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "API Token取得ページ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 561);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "Form1";
            this.Text = "sakura.io Test";
            this.jsonMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelNumBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.csvListMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeOffsetNumBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button websocketConnectButton;
        private System.Windows.Forms.ListBox jsonPreviewList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.NumericUpDown channelNumBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox targetModuleBox;
        private System.Windows.Forms.Button getProjectListButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apiTokenBox;
        private System.Windows.Forms.TextBox apiSecretBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox projectListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button exportRxButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView txQueueListView;
        private System.Windows.Forms.ColumnHeader Channel;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Datetime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label apiStateLabel;
        private System.Windows.Forms.ComboBox projectModuleList;
        private System.Windows.Forms.Button getModuleListButton;
        private System.Windows.Forms.Button setTargetModuleButton;
        private System.Windows.Forms.Button searchProjectFromWebSocketTokenButton;
        private System.Windows.Forms.Button apiAuthButton;
        private System.Windows.Forms.Button autoSetupWebSocketTokenButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addTxDataButton;
        private System.Windows.Forms.NumericUpDown timeOffsetNumBox;
        private System.Windows.Forms.Button clearTxQueueButton;
        private System.Windows.Forms.Button clearRxButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView csvPreviewListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip csvListMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csvListCopyMenuItem;
        private System.Windows.Forms.ContextMenuStrip jsonMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jsonListCopyMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox channelTypeCheckBox;
        private System.Windows.Forms.CheckBox keepaliveTypeCheckBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button importTxButton;
        private System.Windows.Forms.Button exportTxButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

