using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PolicyAsset
    {
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }

        [DataMember]
        [JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_supply")]
        public string? TotalSupply { get; set; }
        
        [DataMember]
        [JsonPropertyName("decimals")]
        public uint? Decimals { get; set; }
    }
}