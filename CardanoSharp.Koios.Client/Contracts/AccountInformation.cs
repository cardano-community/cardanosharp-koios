using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AccountInformation
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }

        [DataMember]
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [DataMember]
        [JsonPropertyName("delegated_pool")]
        public string? DelegatedPool { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_balance")]
        public string? TotalBalance { get; set; }
        
        [DataMember]
        [JsonPropertyName("utxo")]
        public string? Utxo { get; set; }
        
        [DataMember]
        [JsonPropertyName("rewards")]
        public string? Rewards { get; set; }
        
        [DataMember]
        [JsonPropertyName("withdrawals")]
        public string? Withdrawals { get; set; }
        
        [DataMember]
        [JsonPropertyName("rewards_available")]
        public string? RewardsAvailable { get; set; }
        
        [DataMember]
        [JsonPropertyName("reserves")]
        public string? Reserves { get; set; }
        
        [DataMember]
        [JsonPropertyName("treasury")]
        public string? Treasury { get; set; }
    }
}