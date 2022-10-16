using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class TokenomicStats
    {
        [DataMember]
        [JsonPropertyName("epoch_no")]
        public uint EpochNo { get; set; }

        [DataMember]
        [JsonPropertyName("circulation")]
        public string? Circulation { get; set; }

        [DataMember]
        [JsonPropertyName("treasury")]
        public string? Treasury { get; set; }

        [DataMember]
        [JsonPropertyName("reward")]
        public string? Reward { get; set; }

        [DataMember]
        [JsonPropertyName("supply")]
        public string? Supply { get; set; }

        [DataMember]
        [JsonPropertyName("reserves")]
        public string? Reserves { get; set; }
    }
}