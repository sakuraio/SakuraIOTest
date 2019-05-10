using System;
using System.Runtime.Serialization;

namespace SakuraIO
{
    [DataContract]
    public class Project
    {
        [DataMember(Name = "id")]
        public int ID { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "options")]
        public ProjectOptions Options { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: \t{1}", ID, Name);
        }
    }

    [DataContract]
    public class ProjectOptions
    {
        [DataMember(Name = "location")]
        public bool Location { get; set; }
        [DataMember(Name = "datastore")]
        public string Datastore { get; set; }
    }
}
