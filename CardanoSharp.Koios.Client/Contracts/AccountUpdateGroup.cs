using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AccountUpdateGroup
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }

        [DataMember]
        [JsonPropertyName("updates")]
        public AccountUpdate[]? Updates { get; set; }
    }

    [DataContract]
    public class AccountUpdate
    {
        [DataMember]
        [JsonPropertyName("action_type")]
        public string? ActionType { get; set; }

        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }

        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint? Epoch { get; set; }

        [DataMember]
        [JsonPropertyName("epoch_slot")]
        public uint? EpochSlot { get; set; }

        [DataMember]
        [JsonPropertyName("absolute_slot")]
        public uint? AbsoluteSlot { get; set; }

        [DataMember]
        [JsonPropertyName("block_time")]
        public ulong? BlockTime { get; set; }
    }
}