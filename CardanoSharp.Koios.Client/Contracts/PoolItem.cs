using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PoolItem
    {
        [DataMember]
        [JsonPropertyName("pool_id_bech32")]
        public string? PoolIdBech32 { get; set; }
        
        [DataMember]
        [JsonPropertyName("ticker")]
        public string? Ticker { get; set; }
    }
}