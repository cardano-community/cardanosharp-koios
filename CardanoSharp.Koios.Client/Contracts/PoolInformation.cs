using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class PoolInformation
    {
        [DataMember]
        [JsonPropertyName("pool_id_bech32")]
        public string? PoolIdBech32 { get; set; }
        
        [DataMember]
        [JsonPropertyName("pool_id_hex")]
        public string? PoolIdHex { get; set; }
        
        [DataMember]
        [JsonPropertyName("active_epoch_no")]
        public uint ActiveEpochNo { get; set; }
        
        [DataMember]
        [JsonPropertyName("vrf_key_hash")]
        public string? VrfKeyHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("margin")]
        public decimal Margin { get; set; }
        
        [DataMember]
        [JsonPropertyName("fixed_cost")]
        public string? FixedCost { get; set; }
        
        [DataMember]
        [JsonPropertyName("pledge")]
        public string? Pledge { get; set; }
        
        [DataMember]
        [JsonPropertyName("reward_addr")]
        public string? RewardAddress { get; set; }
        
        [DataMember]
        [JsonPropertyName("meta_url")]
        public string? MetaUrl { get; set; }
        
        [DataMember]
        [JsonPropertyName("meta_hash")]
        public string? MetaHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("pool_status")]
        public string? PoolStatus { get; set; }
        
        [DataMember]
        [JsonPropertyName("retiring_epoch")]
        public uint? RetiringEpoch { get; set; }
        
        [DataMember]
        [JsonPropertyName("op_cert")]
        public string? OpCert { get; set; }
        
        [DataMember]
        [JsonPropertyName("op_cert_counter")]
        public uint? OpCertCounter { get; set; }
        
        [DataMember]
        [JsonPropertyName("active_stake")]
        public string? ActiveStake { get; set; }

        [DataMember]
        [JsonPropertyName("sigma")]
        public decimal? Sigma { get; set; }

        [DataMember]
        [JsonPropertyName("block_count")]
        public uint? BlockCount { get; set; }

        [DataMember]
        [JsonPropertyName("live_pledge")]
        public string? LivePledge { get; set; }

        [DataMember]
        [JsonPropertyName("live_stake")]
        public string? LiveStake { get; set; }
        
        [DataMember]
        [JsonPropertyName("live_delegators")]
        public uint LiveDelegators { get; set; }
        
        [DataMember]
        [JsonPropertyName("live_saturation")]
        public decimal LiveSaturation { get; set; }
        
        [DataMember]
        [JsonPropertyName("owners")]
        public List<string>? Owners { get; set; }
        
        [DataMember]
        [JsonPropertyName("meta_json")]
        public Dictionary<string, string>? MetaJson { get; set; }
        
        [DataMember]
        [JsonPropertyName("relays")]
        public Relay[]? Relays { get; set; }
    }
}