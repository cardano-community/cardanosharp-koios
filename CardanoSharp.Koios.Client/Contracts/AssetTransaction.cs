using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AssetTransaction
    {
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }

        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }

        [DataMember]
        [JsonPropertyName("block_height")]
        public uint BlockHeight { get; set; }

        [DataMember]
        [JsonPropertyName("block_time")]
        public ulong BlockTime { get; set; }
    }
}