using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AddressInformation
    {
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [DataMember]
        [JsonPropertyName("balance")]
        public string? Balance { get; set; }
        
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }

        [DataMember]
        [JsonPropertyName("script_address")]
        public bool ScriptAddress { get; set; }

        [DataMember]
        [JsonPropertyName("utxo_set")]
        public AddressUtxoSet[]? UtxoSets { get; set; }
    }

    [DataContract]
    public class AddressUtxoSet
    {
        [DataMember]
        [JsonPropertyName("tx_hash")]
        public string? TxHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_index")]
        public uint TxIndex { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_height")]
        public uint? BlockHeight { get; set; }

        [DataMember]
        [JsonPropertyName("block_time")]
        public ulong? BlockTime { get; set; }

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
        public AssetListInformation[]? AssetList { get; set; }
    }
}