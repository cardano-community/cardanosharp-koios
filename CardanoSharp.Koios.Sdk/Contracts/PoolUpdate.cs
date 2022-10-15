using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class PoolUpdate: PoolInformation
    {
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_time")]
        public ulong? BlockTime { get; set; }
    }
}