using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class EpochInformation
    {
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint? EpochNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("out_sum")]
        public string? OutSum { get; set; }
        
        [DataMember]
        [JsonPropertyName("fees")]
        public string? Fees { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_count")]
        public uint? TxCount { get; set; }
        
        [DataMember]
        [JsonPropertyName("blk_count")]
        public uint? BlkCount { get; set; }

        [DataMember]
        [JsonPropertyName("start_time")]
        public ulong? StartTime { get; set; }

        [DataMember]
        [JsonPropertyName("end_time")]
        public ulong? EndTime { get; set; }

        [DataMember]
        [JsonPropertyName("first_block_time")]
        public ulong? FirstBlockTime { get; set; }
        
        [DataMember]
        [JsonPropertyName("last_block_time")]
        public ulong? LastBlockTime { get; set; }

        [DataMember]
        [JsonPropertyName("active_stake")]
        public string? ActiveStake { get; set; }

        [DataMember]
        [JsonPropertyName("total_rewards")]
        public string? TotalRewards { get; set; }

        [DataMember]
        [JsonPropertyName("avg_blk_reward")]
        public string? AverageBlockReward { get; set; }
    }
}