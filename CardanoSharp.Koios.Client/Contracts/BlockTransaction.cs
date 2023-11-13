using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class BlockTransaction
    {
        [DataMember]
        [JsonPropertyName("block_hash")]
        public string? BlockHash { get; set; }

        [DataMember]
        [JsonPropertyName("tx_hashes")]
        public string[]? TxHashes { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint? Epoch { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_height")]
        public uint? BlockHeight { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_time")]
        public ulong? BlockTime { get; set; }
    }
}