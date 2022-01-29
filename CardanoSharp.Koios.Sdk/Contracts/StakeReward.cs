using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class StakeReward
    {
        [DataMember]
        [JsonPropertyName("earned_epoch")]
        public uint EarnedEpoch { get; set; }

        [DataMember]
        [JsonPropertyName("spendable_epoch")]
        public uint SpendableEpoch { get; set; }

        [DataMember]
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }

        [DataMember]
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [DataMember]
        [JsonPropertyName("pool_id")]
        public string? PoolId { get; set; }
    }
}