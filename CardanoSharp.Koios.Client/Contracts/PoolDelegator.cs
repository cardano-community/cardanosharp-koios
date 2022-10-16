using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client
{
    [DataContract]
    public class PoolDelegator
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        
        [DataMember]
        [JsonPropertyName("active_epoch_no")]
        public uint ActiveEpochNo { get; set; }

        [DataMember]
        [JsonPropertyName("latest_delegation_hash")]
        public string? LatestDelegationHash { get; set; }
    }
}