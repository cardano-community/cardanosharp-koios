using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class BlockInformation: Block
    {
        [DataMember]
        [JsonPropertyName("op_cert")]
        public string? OpCert { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_output")]
        public string? TotalOutput { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_fees")]
        public string? TotalFees { get; set; }
        
        [DataMember]
        [JsonPropertyName("num_confirmations")]
        public uint? NumConfirmations { get; set; }
        
        [DataMember]
        [JsonPropertyName("parent_hash")]
        public string? ParentHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("child_hash")]
        public string? ChildHash { get; set; }
    }
}