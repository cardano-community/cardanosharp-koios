using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class ReserveWithdrawal
    {
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_height")]
        public uint BlockHeight { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_hash")]
        public string? BlockHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_slot")]
        public uint EpochSlot { get; set; }
        
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
    }
}