using System;
using System.Runtime.Serialization;

namespace Panda_Core
{
    [DataContract]
    public class SecurityData
    {
        [DataMember]
        public string SecId { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public DateTime Timestamp { get; set; }
    }
}
