using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
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
    }
}