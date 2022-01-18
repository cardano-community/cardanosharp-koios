using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class StakeUpdate
    {
        [DataMember]
        [JsonPropertyName("action_type")]
        public string? ActionType { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
    }
}