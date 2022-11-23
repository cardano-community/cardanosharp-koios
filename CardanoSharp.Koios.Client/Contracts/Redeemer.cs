using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class Redeemer
    {
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_index")]
        public uint TxIndex { get; set; }
        
        [DataMember]
        [JsonPropertyName("unit_mem")]
        public ulong UnitMem { get; set; }
        
        [DataMember]
        [JsonPropertyName("unit_steps")]
        public ulong UnitSteps { get; set; }
        
        [DataMember]
        [JsonPropertyName("fee")]
        public string? Fee { get; set; }
        
        [DataMember]
        [JsonPropertyName("purpose")]
        public string? Purpose { get; set; }
        
        [DataMember]
        [JsonPropertyName("datum_hash")]
        public string? DatumHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("datum_value")]
        public Dictionary<string, object>? DatumValues { get; set; }
    }
}