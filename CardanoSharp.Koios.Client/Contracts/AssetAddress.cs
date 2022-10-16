using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AssetAddress
    {        
        ///<summary>
        ///Refered to as "payment_address" in the koios docs.
        ///</summary>
        [DataMember]
        [JsonPropertyName("payment_address")]
        public string? Address { get; set; }
        
        [DataMember]
        [JsonPropertyName("quantity")]
        public string? Quantity { get; set; }
    }
}
