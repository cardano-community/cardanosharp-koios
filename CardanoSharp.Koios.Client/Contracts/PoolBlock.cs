using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PoolBlock
    {
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_slot_no")]
        public uint EpochSlotNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_no")]
        public uint BlockNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("slot_no")]
        public uint SlotNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_hash")]
        public string? BlockHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_time")]
        public ulong? BlockTime { get; set; }
    }
}