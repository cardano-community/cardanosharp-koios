using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class StakeAsset
    {
        [DataMember]
        [JsonPropertyName("asset_policy")]
        public string? AssetPolicy { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }
        
        [DataMember]
        [JsonPropertyName("quantity")]
        public ulong Quantity { get; set; }
    }
}