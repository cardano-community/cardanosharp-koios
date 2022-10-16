using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PoolStakeSnapshot
    {
        [DataMember]
        [JsonPropertyName("snapshot")]
        public string? Snapshot { get; set; }

        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }

        [DataMember]
        [JsonPropertyName("nonce")]
        public string? Nonce { get; set; }

        [DataMember]
        [JsonPropertyName("pool_stake")]
        public string? PoolStake { get; set; }

        [DataMember]
        [JsonPropertyName("active_stake")]
        public string? ActiveStake { get; set; }
    }
}