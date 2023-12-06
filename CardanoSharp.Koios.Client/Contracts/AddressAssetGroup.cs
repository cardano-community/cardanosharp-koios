using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AddressAssetGroup: AssetListInformation
    {
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }
    }
}