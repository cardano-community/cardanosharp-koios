using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class StakeInformation
    {
        [DataMember]
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [DataMember]
        [JsonPropertyName("delegated_pool")]
        public string? DelegatedPool { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_balance")]
        public ulong TotalBalance { get; set; }
        
        [DataMember]
        [JsonPropertyName("utxo")]
        public ulong Utxo { get; set; }
        
        [DataMember]
        [JsonPropertyName("rewards")]
        public ulong Rewards { get; set; }
        
        [DataMember]
        [JsonPropertyName("withdrawals")]
        public ulong Withdrawals { get; set; }
        
        [DataMember]
        [JsonPropertyName("rewards_available")]
        public ulong RewardsAvailable { get; set; }
        
        [DataMember]
        [JsonPropertyName("reserves")]
        public long Reserves { get; set; }
        
        [DataMember]
        [JsonPropertyName("treasury")]
        public ulong Treasury { get; set; }
    }
}