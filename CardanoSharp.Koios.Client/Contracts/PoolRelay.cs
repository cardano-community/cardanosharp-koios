using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PoolRelay
    {
        [DataMember]
        [JsonPropertyName("pool_id_bech32")]
        public string? PoolIdBech32 { get; set; }
        
        [DataMember]
        [JsonPropertyName("relays")]
        public List<Relay>? Relays { get; set; }
    }
}