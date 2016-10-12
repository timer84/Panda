using System.Runtime.Serialization;

namespace Panda_Core
{
    [DataContract]
    public class Security
    {
        [DataMember]
        public string SecId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Exchange { get; set; }

        [DataMember]
        public string Type { get; set; }
    }
}
