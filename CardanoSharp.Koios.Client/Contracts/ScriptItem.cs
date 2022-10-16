using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class ScriptItem
    {
        [DataMember]
        [JsonPropertyName("script_hash")]
        public string? ScriptHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("creation_tx_hash")]
        public string? CreationTxHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}