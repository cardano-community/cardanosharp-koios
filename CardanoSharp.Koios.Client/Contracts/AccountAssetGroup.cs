using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AccountAssetGroup
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public AccountPolicyAssets[]? Assets { get; set; }
    }

    [DataContract]
    public class AccountPolicyAssets
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }

        [DataMember]
        [JsonPropertyName("assets")]
        public AccountAsset[]? Assets { get; set; }
    }

    [DataContract]
    public class AccountAsset
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
    }
}