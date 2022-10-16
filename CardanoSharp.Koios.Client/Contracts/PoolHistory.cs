using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PoolHistory
    {
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }

        [DataMember]
        [JsonPropertyName("active_stake")]
        public string? ActiveStake { get; set; }

        [DataMember]
        [JsonPropertyName("active_stake_pct")]
        public decimal? ActiveStakePct { get; set; }

        [DataMember]
        [JsonPropertyName("saturation_pct")]
        public decimal? SaturationPct { get; set; }

        [DataMember]
        [JsonPropertyName("block_cnt")]
        public uint? BlockCount{ get; set; }

        [DataMember]
        [JsonPropertyName("delegator_cnt")]
        public uint? DelegatorCount { get; set; }

        [DataMember]
        [JsonPropertyName("margin")]
        public decimal? Margin { get; set; }

        [DataMember]
        [JsonPropertyName("fixed_cost")]
        public string? FixedCost { get; set; }

        [DataMember]
        [JsonPropertyName("pool_fees")]
        public string? PoolFees { get; set; }

        [DataMember]
        [JsonPropertyName("deleg_rewards")]
        public string? DelegatorRewards { get; set; }

        [DataMember]
        [JsonPropertyName("epoch_ros")]
        public decimal? EpochRos { get; set; }
    }
}