using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AssetHistory
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }

        [DataMember]
        [JsonPropertyName("minting_txs")]
        public MintingTransaction[]? MintingTransactions{ get; set; }
    }

    public class MintingTransaction
    {

        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }

        [DataMember]
        [JsonPropertyName("block_time")]
        public ulong? BlockTime { get; set; }

        [DataMember]
        [JsonPropertyName("quantity")]
        public string? Quantity { get; set; }

        [DataMember]
        [JsonPropertyName("metadata")]
        public object? Metadata { get; set; }
    }
}