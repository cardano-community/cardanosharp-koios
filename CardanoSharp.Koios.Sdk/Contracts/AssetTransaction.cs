using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class AssetTransaction
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_transactions")]
        public uint TotalTransactions { get; set; }
        
        [DataMember]
        [JsonPropertyName("staked_wallets")]
        public uint StakedWallets { get; set; }
        
        [DataMember]
        [JsonPropertyName("unstaked_addresses")]
        public uint UnstakedAddresses { get; set; }
    }
}