using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class Relay
    {
        [DataMember]
        [JsonPropertyName("dns")]
        public string? Dns { get; set; }
        
        [DataMember]
        [JsonPropertyName("srv")]
        public string? Srv { get; set; }
        
        [DataMember]
        [JsonPropertyName("ipv4")]
        public string? Ipv4 { get; set; }
        
        [DataMember]
        [JsonPropertyName("ipv6")]
        public string? Ipv6 { get; set; }
        
        [DataMember]
        [JsonPropertyName("port")]
        public uint? Port { get; set; }
        
    }
}