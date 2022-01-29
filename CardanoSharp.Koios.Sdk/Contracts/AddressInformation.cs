using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class AddressInformation
    {
        [DataMember]
        [JsonPropertyName("balance")]
        public string? Balance { get; set; }
        
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("utxo_set")]
        public IEnumerable<AddressUtxoSet> UtxoSets { get; set; }
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
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
        [DataMember]
        [JsonPropertyName("asset_list")]
        public List<AddressAsset> AssetList { get; set; }
    }    
    
    [DataContract]
    public class AddressAsset
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
}