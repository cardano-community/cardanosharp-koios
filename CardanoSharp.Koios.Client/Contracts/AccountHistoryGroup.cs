using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AccountHistoryGroup
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("history")]
        public AccountStakeHistory[]? History { get; set; }
    }
    
    [DataContract]
    public class AccountStakeHistory
    {
        [DataMember]
        [JsonPropertyName("pool_id")]
        public string? PoolId { get; set; }

        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }

        [DataMember]
        [JsonPropertyName("active_stake")]
        public string? ActiveStake { get; set; }
    }
}