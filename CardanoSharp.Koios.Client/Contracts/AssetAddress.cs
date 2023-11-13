using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AssetAddress
    {        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }
        
        [DataMember]
        [JsonPropertyName("payment_address")]
        public string? Address { get; set; }
        
        [DataMember]
        [JsonPropertyName("quantity")]
        public string? Quantity { get; set; }
    }
}
