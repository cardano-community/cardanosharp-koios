using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class ProtocolParameters
    {
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint? EpochNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("min_fee_a")]
        public uint? MinFeeA { get; set; }
        
        [DataMember]
        [JsonPropertyName("min_fee_b")]
        public uint? MinFeeB { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_block_size")]
        public uint? MaxBlockSize { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_tx_size")]
        public uint? MaxTxSize { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_bh_size")]
        public uint? MaxBhSize { get; set; }
        
        [DataMember]
        [JsonPropertyName("key_deposit")]
        public string? KeyDeposit { get; set; }
        
        [DataMember]
        [JsonPropertyName("pool_deposit")]
        public string? PoolDeposit { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_epoch")]
        public uint? MaxEpoch { get; set; }
        
        [DataMember]
        [JsonPropertyName("optimal_pool_count")]
        public uint? OptimalPoolCount { get; set; }
        
        [DataMember]
        [JsonPropertyName("influence")]
        public decimal? Influence { get; set; }
        
        [DataMember]
        [JsonPropertyName("monetary_expand_rate")]
        public decimal? MonetaryExpandRate { get; set; }
        
        [DataMember]
        [JsonPropertyName("treasury_growth_rate")]
        public decimal? TreasuryGrowthRate { get; set; }
        
        [DataMember]
        [JsonPropertyName("decentralisation")]
        public decimal? Decentralisation { get; set; }
        
        [DataMember]
        [JsonPropertyName("extra_entropy")]
        public string? Entropy { get; set; }
        
        [DataMember]
        [JsonPropertyName("protocol_major")]
        public uint? ProtocolMajor { get; set; }
        
        [DataMember]
        [JsonPropertyName("protocol_minor")]
        public uint? ProtocolMinor { get; set; }
        
        [DataMember]
        [JsonPropertyName("min_utxo_value")]
        public string? MinUtxoValue { get; set; }
        
        [DataMember]
        [JsonPropertyName("min_pool_cost")]
        public string? MinPoolCost { get; set; }
        
        [DataMember]
        [JsonPropertyName("nonce")]
        public string? Nonce { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_hash")]
        public string? BlockHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("cost_models")]
        public string? CostModels { get; set; }
        
        [DataMember]
        [JsonPropertyName("price_mem")]
        public decimal? PriceMem { get; set; }
        
        [DataMember]
        [JsonPropertyName("price_step")]
        public decimal? PriceStep { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_tx_ex_mem")]
        public uint? MaxTxExMem { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_tx_ex_steps")]
        public ulong? MaxTxExSteps { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_block_ex_mem")]
        public uint? MaxBlockExMem { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_block_ex_steps")]
        public ulong? MaxBlockExSteps { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_val_size")]
        public uint? MaxValSize { get; set; }
        
        [DataMember]
        [JsonPropertyName("collateral_percent")]
        public uint? CollateralPercent { get; set; }
        
        [DataMember]
        [JsonPropertyName("max_collateral_inputs")]
        public uint? MaxCollateralInputs { get; set; }
        
        [DataMember]
        [JsonPropertyName("coins_per_utxo_size")]
        public string? CoinsPerUtxoSize { get; set; }
    }
}