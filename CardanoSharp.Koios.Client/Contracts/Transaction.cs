using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
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
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_slot")]
        public uint EpochSlot { get; set; }
        
        [DataMember]
        [JsonPropertyName("absolute_slot")]
        public uint AbsoluteSlot { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_timestamp")]
        public long? TxTimestamp { get; set; }
        
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
        [JsonPropertyName("collateral_inputs")]
        public IEnumerable<Utxo>? CollateralInputs { get; set; }

        [DataMember]
        [JsonPropertyName("collateral_output")]
        public Utxo? CollateralOutput { get; set; }

        [DataMember]
        [JsonPropertyName("reference_inputs")]
        public IEnumerable<Utxo>? ReferenceInputs { get; set; }

        [DataMember]
        [JsonPropertyName("inputs")]
        public IEnumerable<Utxo>? Inputs { get; set; }
        
        [DataMember]
        [JsonPropertyName("outputs")]
        public IEnumerable<Utxo>? Outputs { get; set; }
        
        [DataMember]
        [JsonPropertyName("withdrawals")]
        public IEnumerable<TransactionWithdrawal>? Withdrawals { get; set; }
        
        [DataMember]
        [JsonPropertyName("assets_minted")]
        public IEnumerable<AssetListInformation>? AssetsMinted { get; set; }
        
        [DataMember]
        [JsonPropertyName("metadata")]
        public IEnumerable<Metadata>? Metadata { get; set; }
        
        [DataMember]
        [JsonPropertyName("certificates")]
        public IEnumerable<TransactionCertificate>? Certificates { get; set; }

        [DataMember]
        [JsonPropertyName("native_scripts")]
        public IEnumerable<NativeScript>? NativeScripts { get; set; }

        [DataMember]
        [JsonPropertyName("plutus_contracts")]
        public IEnumerable<PlutusContract>? PlutusContracts { get; set; }
    }

    public class Utxo
    {
        [DataMember]
        [JsonPropertyName("payment_addr")]
        public TransactionPaymentAddress? PaymentAddress { get; set; }
        
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
        [JsonPropertyName("datum_hash")]
        public string? DatumHash { get; set; }

        [DataMember]
        [JsonPropertyName("inline_datum")]
        public InlineDatum? InlineDatum { get; set; }

        [DataMember]
        [JsonPropertyName("reference_script")]
        public ReferenceScript? ReferenceScript { get; set; }

        [DataMember]
        [JsonPropertyName("asset_list")]
        public IEnumerable<AssetListInformation>? AssetList { get; set; }
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

    public class TransactionWithdrawal
    {
        [DataMember]
        [JsonPropertyName("stake_addr")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("amount")]
        public string? Amount { get; set; }
    }

    public class Metadata
    {
        [DataMember]
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        
        [DataMember]
        [JsonPropertyName("json")]
        public object? Json { get; set; }
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
        public TransactionCertificateInfo? Info { get; set; }
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

    public class InlineDatum
    {
        [DataMember]
        [JsonPropertyName("bytes")]
        public string? Bytes { get; set; }

        [DataMember]
        [JsonPropertyName("value")]
        public object? Value { get; set; }
    }

    public class ReferenceScript
    {
        [DataMember]
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }

        [DataMember]
        [JsonPropertyName("size")]
        public uint? Size { get; set; }

        [DataMember]
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [DataMember]
        [JsonPropertyName("bytes")]
        public string? Bytes { get; set; }

        [DataMember]
        [JsonPropertyName("value")]
        public object? Value { get; set; }
    }

    public class NativeScript
    {
        [DataMember]
        [JsonPropertyName("script_hash")]
        public string? ScriptHash { get; set; }

        [DataMember]
        [JsonPropertyName("script_json")]
        public object? ScriptJson { get; set; }
    }

    public class PlutusContract
    {
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [DataMember]
        [JsonPropertyName("script_hash")]
        public string? ScriptHash { get; set; }

        [DataMember]
        [JsonPropertyName("bytecode")]
        public string? Bytecode { get; set; }

        [DataMember]
        [JsonPropertyName("size")]
        public uint? Size { get; set; }

        [DataMember]
        [JsonPropertyName("valid_contract")]
        public bool? ValidContract { get; set; }

        [DataMember]
        [JsonPropertyName("input")]
        public object? Input { get; set; }

        [DataMember]
        [JsonPropertyName("output")]
        public PlutusContractDatum? Output { get; set; }
    }

    public class PlutusContractInput
    {
        [DataMember]
        [JsonPropertyName("redeemer")]
        public PlutusContractRedeemer? Redeemer { get; set; }

        [DataMember]
        [JsonPropertyName("datum")]
        public PlutusContractDatum? Datum { get; set; }
    }

    public class PlutusContractRedeemer
    {
        [DataMember]
        [JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        [DataMember]
        [JsonPropertyName("fee")]
        public uint? Fee { get; set; }

        [DataMember]
        [JsonPropertyName("unit")]
        public PlutusContractUnit? Unit { get; set; }

        [DataMember]
        [JsonPropertyName("datum")]
        public PlutusContractDatum? Datum { get; set; }
    }

    public class PlutusContractUnit
    {
        [DataMember]
        [JsonPropertyName("steps")]
        public ulong? Steps { get; set; }

        [DataMember]
        [JsonPropertyName("mem")]
        public ulong? Mem { get; set; }
    }

    public class PlutusContractDatum
    {
        [DataMember]
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }

        [DataMember]
        [JsonPropertyName("value")]
        public object? Value { get; set; }
    }
}