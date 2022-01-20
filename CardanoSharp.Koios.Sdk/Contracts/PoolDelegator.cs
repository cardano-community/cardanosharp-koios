using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk
{
    [DataContract]
    public class PoolDelegator
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("amount")]
        public ulong Amount { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }
    }
}