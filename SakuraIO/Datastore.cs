namespace SakuraIO
{
    class DatastoreClient
    {
        /// <summary>
        /// Datastoreを叩くやつ
        /// 現在未実装
        /// </summary>

        private string apiToken;
        private string apiSecret;

        #region Constructor
        public DatastoreClient() { }

        public DatastoreClient(string _apiToken, string _apiSecret)
        {
            SetAPIToken(_apiToken, _apiSecret);
        }
        #endregion


        public void SetAPIToken(string _apiToken, string _apiSecret)
        {
            apiToken = _apiToken;
            apiSecret = _apiSecret;
        }


    }
}
