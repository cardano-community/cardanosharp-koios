using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class AssetInformation
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
        [JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }
        
        [DataMember]
        [JsonPropertyName("minting_tx_metadata")]
        public object MintingTxMetadata { get; set; }
        
        [DataMember]
        [JsonPropertyName("token_registry_metadata")]
        public object TokenRegistryMetadata { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_supply")]
        public string? TotalSupply { get; set; }
        
        [DataMember]
        [JsonPropertyName("creation_time")]
        public DateTime CreationTime { get; set; }
    }
}