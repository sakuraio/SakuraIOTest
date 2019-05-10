using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.WebSockets;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SakuraIO
{
    public class Client
    {
        private string apiToken;
        private string apiSecret;
        private string wsToken;
        private ClientWebSocket sakuraioSocket;
        const int MessageBufferSize = 102400;

        public delegate void OnMessageHandler(ISakuraIOMessage message);
        public delegate void OnConnectHandler(bool isSucceeded);
        public delegate void OnCloseHandler();

        private string getBasicAuthString() => Convert.ToBase64String(Encoding.UTF8.GetBytes(apiToken + ":" + apiSecret));

        #region Property
        public bool IsWebSocketOpened => sakuraioSocket != null && sakuraioSocket.State == WebSocketState.Open;

        public bool IsAPIAuthenticated { get; private set; } = false;
        #endregion

        #region Constructor
        public Client() { }

        public Client(string _apiToken, string _apiSecret)
        {
            SetAPIToken(_apiToken, _apiSecret);
        }
        #endregion

        #region Exceptions
        public class APIException : Exception
        {
            public APIException(string message) : base(message)
            {
            }
        }
        public class WebSocketException : Exception
        {
            public WebSocketException(string message) : base(message)
            {
            }
        }
        #endregion

        public void SetAPIToken(string _apiToken, string _apiSecret)
        {
            apiToken = _apiToken;
            apiSecret = _apiSecret;
        }

        public void SetWebSocketToken(string _wsToken) => wsToken = _wsToken;

        public async Task<bool> AuthenticateAPI()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://api.sakura.io/v1/auth/");
                request.Headers.Add(@"Authorization", @"Basic " + getBasicAuthString());

                var response = await client.SendAsync(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    IsAPIAuthenticated = false;
                    throw new Exception("API request failed");
                }
            }
            IsAPIAuthenticated = true;
            return true;
        }

        public async Task<List<Module>> GetModulesFromProjectID(int project_id)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, string.Format("https://api.sakura.io/v1/modules/?project={0}", project_id));
                request.Headers.Add(@"Authorization", @"Basic " + getBasicAuthString());

                var response = await client.SendAsync(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("API request failed");
                }


                var serializer = new DataContractJsonSerializer(typeof(List<Module>));
                var modules = (List<Module>)serializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(await response.Content.ReadAsStringAsync())));

                return modules;
            }
            throw new NotImplementedException();
        }

        public async Task<List<Project>> GetProjects()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, @"https://api.sakura.io/v1/projects/");
                request.Headers.Add(@"Authorization", @"Basic " + getBasicAuthString());

                var response = await client.SendAsync(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("API request failed");
                }


                var serializer = new DataContractJsonSerializer(typeof(List<Project>));
                var projects = (List<Project>)serializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(await response.Content.ReadAsStringAsync())));

                return projects;
            }
        }

        public async Task<List<Service>> GetServices()
        {

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, @"https://api.sakura.io/v1/services/");
                request.Headers.Add(@"Authorization", @"Basic " + getBasicAuthString());

                var response = await client.SendAsync(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("API request failed");
                }


                var serializer = new DataContractJsonSerializer(typeof(List<Service>));
                var services = (List<Service>)serializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(await response.Content.ReadAsStringAsync())));
                return services;
            }
        }

        public async Task<int> GetProjectIDFromServiceToken(string serviceToken)
        {
            var services = await GetServices();
            var service = services.Where(x => x.Token == serviceToken).Select(x => x).Single();

            return service.ProjectID;
        }

        public async Task<List<Service>> GetServicesFromProject(Project project)
        {
            var service_all = await GetServices();
            var services = service_all.Where(x => x.ProjectID == project.ID).ToList();

            return services;
        }

        public async Task<List<Service>> GetServicesFromProject(int project_id)
        {
            var service_all = await GetServices();
            var services = service_all.Where(x => x.ProjectID == project_id).ToList();

            return services;
        }

        public async Task<Service> CreateService(int project_id, string name, string type)
        {
            var parameters = new Dictionary<string, object>()
            {
                {"name",  name},
                {"type", type },
                {"project", project_id },
            };
            var request = new HttpRequestMessage(HttpMethod.Post, @"https://api.sakura.io/v1/services/");
            request.Headers.Add(@"Authorization", @"Basic " + getBasicAuthString());
            request.Content = new StringContent($"{{\"name\": \"{name}\", \"type\": \"{type}\", \"project\": {project_id}}}", Encoding.UTF8);
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(request);
                var resp_str = await response.Content.ReadAsStringAsync();
                Console.WriteLine(resp_str);

                var serializer = new DataContractJsonSerializer(typeof(Service));
                var service = (Service)serializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(resp_str)));
                return service;
            }
        }

        private ChannelMessage DeserializeChannelMessage(string frameString)
        {
            try
            {
                var serializer = new DataContractJsonSerializer(typeof(ChannelMessage));
                // nullで刺さる
                return (ChannelMessage)serializer.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(frameString)));

            }
            catch (Exception)
            {
                return null;
            }
        }

        private string SerializeChannelMessage(ISakuraIOMessage message)
        {
            Type type;

            if (message.Type == "channels")
            {
                type = typeof(ChannelMessage);
            }
            else
            {
                throw new InvalidDataException("messageに含まれるtypeの値が不正です");
            }

            using (var ms = new MemoryStream())
            using (var sr = new StreamReader(ms))
            {
                var serializer = new DataContractJsonSerializer(type);
                serializer.WriteObject(ms, message);
                ms.Position = 0;
                return sr.ReadToEnd();
            }
        }


        public async Task ConnectWebSocket(OnMessageHandler onMessageHandler, OnConnectHandler onConnectHandler = null, OnCloseHandler onCloseHandler = null)
        {
            await Task.Run(async () =>
            {
                if (!Guid.TryParse(wsToken, out _))
                {
                    throw new ArgumentException("tokenの値が不正です, UUID形式で入力してください");
                }

                sakuraioSocket = new ClientWebSocket();
                try
                {
                    await sakuraioSocket.ConnectAsync(new Uri("wss://api.sakura.io/ws/v1/" + wsToken), CancellationToken.None);
                }
                catch (System.Net.WebSockets.WebSocketException)
                {
                    throw new WebSocketException("WebSocketの接続に失敗しました");
                }

                // 特に指定がなければ呼ばない
                onConnectHandler?.Invoke(true);

                while (sakuraioSocket.State == WebSocketState.Open)
                {
                    var buff = new ArraySegment<byte>(new byte[MessageBufferSize]);
                    var ret = await sakuraioSocket.ReceiveAsync(buff, CancellationToken.None);

                    if (!ret.EndOfMessage)
                    {
                        continue;
                    }

                    var frameString = (new UTF8Encoding()).GetString(buff.Take(ret.Count).ToArray());
                    Console.WriteLine(frameString);

                    var cmsg = DeserializeChannelMessage(frameString);
                    if (cmsg == null)
                    {
                        continue;
                    }

                    onMessageHandler(cmsg);

                }
                onCloseHandler?.Invoke();
            });
        }

        public async Task SendWebSocket(ISakuraIOMessage msg)
        {

            var jsonStr = SerializeChannelMessage(msg);
            var buff = new ArraySegment<byte>((new UTF8Encoding()).GetBytes(jsonStr));
            Console.WriteLine(jsonStr);

            await sakuraioSocket.SendAsync(buff, WebSocketMessageType.Text, true, CancellationToken.None);

        }

        public async Task CloseWebSocket()
        {
            await sakuraioSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "connection closed by client", CancellationToken.None);
        }
    }
}
