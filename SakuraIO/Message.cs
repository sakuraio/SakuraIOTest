using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SakuraIO
{

    public interface ISakuraIOMessage
    {
        string Module { get; set; }
        string Type { get; set; }
        string Datetime { get; set; }
    }

    [DataContract]
    public class ChannelMessage : ISakuraIOMessage
    {
        [DataMember(Name = "module")]
        public string Module { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "datetime")]
        public string Datetime { get; set; }
        [DataMember(Name = "payload")]
        public Payload Payload { get; set; }

        public ChannelMessage()
        {
            Payload = new Payload();
        }

        public override string ToString()
        {
            

            return "[" + string.Join(", ", Payload.Channels.Select(x => $"{{{x.ToString()}}}")) + "]";
        }
    }

    [DataContract]
    public class Payload
    {
        [DataMember(Name = "channels")]
        public List<Channel> Channels { get; set; }

        public Payload()
        {
            Channels = new List<Channel>();
        }
    }

    [DataContract]
    public class Channel
    {
        [DataMember(Name = "channel")]
        public int ChannelID { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "value")]
        public object Value { get; set; }
        public Int64 ValueInt
        {
            get
            {
                if (Type == "i" || Type == "I" || Type == "l" || Type == "L")
                {
                    return Convert.ToInt64(Value);
                }
                return 0;
            }
        }
        public double ValueFloat
        {
            get
            {
                if (Type == "d" || Type == "f")
                {
                    return Convert.ToDouble(Value);
                }
                return 0.0;
            }
        }
        /*public byte[] valueByte
        {
            get
            {
                if (type == "i" || type == "I")
                {
                    return (int)value;
                }
            }
        }*/

        [DataMember(Name = "datetime")]
        public string Datetime { get; set; }

        public dynamic GetValue()
        {
            if (Type == "i" || Type == "I" || Type == "l" || Type == "L")
            {
                return ValueInt;
            }
            if (Type == "d" || Type == "f")
            {
                return ValueFloat;
            }
            return null;
        }

        public override string ToString()
        {
            return string.Format($"\"channel\": {ChannelID}, \"type\": {Type}, \"value\": {Value}");
        }
    }
}
