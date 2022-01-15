using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class BlockTransaction
    {
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
    }
}