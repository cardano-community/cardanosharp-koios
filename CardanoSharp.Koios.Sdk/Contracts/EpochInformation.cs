using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class EpochInformation
    {
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("out_sum")]
        public string? OutSum { get; set; }
        
        [DataMember]
        [JsonPropertyName("fees")]
        public string? Fees { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_count")]
        public uint TxCount { get; set; }
        
        [DataMember]
        [JsonPropertyName("blk_count")]
        public uint BlkCount { get; set; }
        
        [DataMember]
        [JsonPropertyName("first_block_time")]
        public DateTime FirstBlockTime { get; set; }
        
        [DataMember]
        [JsonPropertyName("last_block_time")]
        public DateTime LastBlockTime { get; set; }
        
        [DataMember]
        [JsonPropertyName("active_stake")]
        public string? ActiveStake { get; set; }
    }
}