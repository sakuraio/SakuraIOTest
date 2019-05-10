using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SakuraIO
{
    [DataContract]
    public class Module
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "project")]
        public int Project { get; set; }
        [DataMember(Name = "is_online")]
        public bool IsOnline { get; set; }
        [DataMember(Name = "serial_number")]
        public string SerialNumber { get; set; }
        [DataMember(Name = "model")]
        public string Model { get; set; }
        [DataMember(Name = "firmware_version")]
        public string FirmwareVersion { get; set; }

        public override string ToString()
        {
            return string.Format("{1} ({0})", ID, Name);
        }

    }
}
