using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AssetTokenRegistry
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name_ascii")]
        public string? AssetNameAscii { get; set; }
        
        [DataMember]
        [JsonPropertyName("ticker")]
        public string? Ticker { get; set; }
        
        [DataMember]
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [DataMember]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        
        [DataMember]
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }
        
        [DataMember]
        [JsonPropertyName("decimals")]
        public uint? Decimals { get; set; }
    }
}