using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AddressUtxo: Utxo
    {
        [DataMember]
        [JsonPropertyName("is_spent")]
        public bool IsSpent { get; set; }
    }
}