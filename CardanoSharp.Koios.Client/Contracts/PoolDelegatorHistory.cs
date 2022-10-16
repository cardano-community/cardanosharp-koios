using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client
{
    [DataContract]
    public class PoolDelegatorHistory
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }
    }
}