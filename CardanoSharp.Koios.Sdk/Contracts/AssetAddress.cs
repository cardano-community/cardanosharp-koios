using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class AssetAddress
    {
        [DataMember]
        [JsonPropertyName("payment_address")]
        public string? PaymentAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("quantity")]
        public string? Quantity { get; set; }
    }
}
