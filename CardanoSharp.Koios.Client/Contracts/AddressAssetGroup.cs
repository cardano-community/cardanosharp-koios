using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AddressAssetGroup
    {
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_list")]
        public AssetListInformation[]? Assets { get; set; }
    }
}