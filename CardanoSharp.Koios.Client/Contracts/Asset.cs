using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class Asset
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }

        [DataMember]
        [JsonPropertyName("asset_names")]
        public AssetNames AssetNames { get; set; }
    }

    [DataContract]
    public class AssetNames
    {
        [DataMember]
        [JsonPropertyName("hex")]
        public IEnumerable<string> Hex { get; set; }

        [DataMember]
        [JsonPropertyName("ascii")]
        public IEnumerable<string> Ascii { get; set; }
    }
}
