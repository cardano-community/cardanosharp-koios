using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AssetSummary
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }

        [DataMember]
        [JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }

        [DataMember]
        [JsonPropertyName("total_transactions")]
        public ulong TotalTransactions { get; set; }
        
        [DataMember]
        [JsonPropertyName("staked_wallets")]
        public ulong StakedWallets { get; set; }

        [DataMember]
        [JsonPropertyName("unstaked_addresses")]
        public ulong UnstakedAddresses { get; set; }
    }
}