using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class AddressAssetGroup
    {
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        
        [DataMember]
        [JsonPropertyName("assets")]
        public AddressPolicyAssets[]? Assets { get; set; }
    }

    [DataContract]
    public class AddressPolicyAssets
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }

        [DataMember]
        [JsonPropertyName("assets")]
        public AddressAsset[]? Assets { get; set; }
    }

    [DataContract]
    public class AddressAsset
    {
        [DataMember]
        [JsonPropertyName("asset_policy")]
        public string? PolicyId { get; set; }

        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }

        [DataMember]
        [JsonPropertyName("balance")]
        public ulong? Balance { get; set; }

        [DataMember]
        [JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }
    }
}