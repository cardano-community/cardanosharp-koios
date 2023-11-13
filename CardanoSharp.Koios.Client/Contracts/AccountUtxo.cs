using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AccountUtxo: AddressTransaction
    {
        [DataMember]
        [JsonPropertyName("tx_index")]
        public uint TxIndex { get; set; }
        
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }
        
        [DataMember]
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("payment_cred")]
        public string? PaymentCred { get; set; }
        
        [DataMember]
        [JsonPropertyName("datum_hash")]
        public string? DatumHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("inline_datum")]
        public InlineDatum? InlineDatum { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_list")]
        public AssetListInformation[]? AssetList { get; set; }
        
        [DataMember]
        [JsonPropertyName("reference_script")]
        public ReferenceScript? ReferenceScript { get; set; }
        
        [DataMember]
        [JsonPropertyName("is_spent")]
        public bool IsSpent { get; set; }
    }
}