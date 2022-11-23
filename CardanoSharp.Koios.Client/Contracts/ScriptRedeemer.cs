using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class ScriptRedeemer
    {
        [DataMember]
        [JsonPropertyName("script_hash")]
        public string? ScriptHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("redeemers")]
        public List<Redeemer>? Redeemers { get; set; }
    }
}