using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PoolMetadata
    {
        [DataMember]
        [JsonPropertyName("pool_id_bech32")]
        public string? PoolIdBech32 { get; set; }
        
        [DataMember]
        [JsonPropertyName("meta_url")]
        public string? MetaUrl { get; set; }
        
        [DataMember]
        [JsonPropertyName("meta_hash")]
        public string? MetaHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("meta_json")]
        public Dictionary<string, string>? MetaJson { get; set; }
    }
}