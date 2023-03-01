using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class BlockProtocol
    {
        [DataMember]
        [JsonPropertyName("proto_major")]
        public uint? ProtoMajor { get; set; }

        [DataMember]
        [JsonPropertyName("proto_minor")]
        public uint? ProtoMinor { get; set; }

        [DataMember]
        [JsonPropertyName("blocks")]
        public uint? Blocks { get; set; }
    }
}
