using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_hash")]
        public string? BlockHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_height")]
        public uint BlockHeight { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch")]
        public uint Epock { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_slot")]
        public uint EpochSlot { get; set; }
        
        [DataMember]
        [JsonPropertyName("absolute_slot")]
        public uint AbsoluteSlot { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_timestamp")]
        public DateTime TxTimestamp { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_block_index")]
        public uint TxBlockIndex { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_size")]
        public uint TxSize { get; set; }
        
        [DataMember]
        [JsonPropertyName("total_output")]
        public string? TotalOutput { get; set; }
        
        [DataMember]
        [JsonPropertyName("fee")]
        public string? Fee { get; set; }
        
        [DataMember]
        [JsonPropertyName("deposit")]
        public string? Deposit { get; set; }
        
        [DataMember]
        [JsonPropertyName("invalid_before")]
        public uint? InvalidBefore { get; set; }
        
        [DataMember]
        [JsonPropertyName("invalid_after")]
        public uint? InvalidAfter { get; set; }
        
        [DataMember]
        [JsonPropertyName("inputs")]
        public IEnumerable<Utxo> Inputs { get; set; }
        
        [DataMember]
        [JsonPropertyName("outputs")]
        public IEnumerable<Utxo> Outputs { get; set; }
        
        [DataMember]
        [JsonPropertyName("withdrawals")]
        public IEnumerable<TransactionWithdrawal> Withdrawals { get; set; }
        
        [DataMember]
        [JsonPropertyName("assets_minted")]
        public IEnumerable<TransactionAsset> AssetsMinted { get; set; }
        
        [DataMember]
        [JsonPropertyName("metadata")]
        public IEnumerable<Metadata> Metadata { get; set; }
        
        [DataMember]
        [JsonPropertyName("certificates")]
        public IEnumerable<TransactionCertificate> Certificates { get; set; }
    }

    public class Utxo
    {
        [DataMember]
        [JsonPropertyName("payment_addr")]
        public TransactionPaymentAddress PaymentAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("stake_addr")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_index")]
        public uint TxIndex { get; set; }
        
        [DataMember]
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_list")]
        public IEnumerable<TransactionAsset> AssetList { get; set; }
    }

    public class TransactionPaymentAddress
    {
        [DataMember]
        [JsonPropertyName("bech32")]
        public string? Bech32 { get; set; }
        
        [DataMember]
        [JsonPropertyName("cred")]
        public string? Cred { get; set; }
    }

    public class TransactionAsset
    {
        [DataMember]
        [JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_name")]
        public string? AssetName { get; set; }
        
        [DataMember]
        [JsonPropertyName("quantity")]
        public string? Quantity { get; set; }
    }

    public class TransactionWithdrawal
    {
        [DataMember]
        [JsonPropertyName("stake_addr")]
        public TransactionPaymentAddress StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
    }

    public class Metadata
    {
        [DataMember]
        [JsonPropertyName("key")]
        public uint Key { get; set; }
        
        [DataMember]
        [JsonPropertyName("json")]
        public object Json { get; set; }
    }

    public class TransactionCertificate
    {
        [DataMember]
        [JsonPropertyName("index")]
        public uint Index { get; set; }
        
        [DataMember]
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_block_index")]
        public TransactionCertificateInfo Info { get; set; }
    }

    public class TransactionCertificateInfo
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("pool")]
        public string? Pool { get; set; }
    }
}