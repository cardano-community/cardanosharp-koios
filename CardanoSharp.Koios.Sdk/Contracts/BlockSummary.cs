using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class BlockSummary
    {
        [DataMember]
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }

        [DataMember]
        [JsonPropertyName("epoch")]
        public uint Epoch { get; set; }

        [DataMember]
        [JsonPropertyName("abs_slot")]
        public ulong AbsSlot { get; set; }

        [DataMember]
        [JsonPropertyName("epoch_slot")]
        public ulong EpochSlot { get; set; }

        [DataMember]
        [JsonPropertyName("block_no")]
        public ulong BlockNo { get; set; }

        [DataMember]
        [JsonPropertyName("block_time")]
        public DateTime BlockTime { get; set; }
    }
}