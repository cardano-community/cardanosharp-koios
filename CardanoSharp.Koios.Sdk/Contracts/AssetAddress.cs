using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class AssetAddress
    {
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        
        [DataMember]
        [JsonPropertyName("quantity")]
        public ulong Quantity { get; set; }
    }
}