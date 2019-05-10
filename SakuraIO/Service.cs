using System.Runtime.Serialization;

namespace SakuraIO
{
    [DataContract]
    public class Service
    {
        [DataMember(Name = "id")]
        public int ID { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "project")]
        public int ProjectID { get; set; }
        [DataMember(Name = "token")]
        public string Token { get; set; }
    }

}
