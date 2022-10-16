using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class GenesisParameters
    {
        [DataMember]
        [JsonPropertyName("networkmagic")]
        public string? NetworkMagic { get; set; }

        [DataMember]
        [JsonPropertyName("networkid")]
        public string? NetworkId { get; set; }

        [DataMember]
        [JsonPropertyName("epochlength")]
        public string? EpochLength { get; set; }

        [DataMember]
        [JsonPropertyName("slotlength")]
        public string? SlotLength { get; set; }

        [DataMember]
        [JsonPropertyName("maxlovelacesupply")]
        public string? MaxLovelaceSupply { get; set; }

        [DataMember]
        [JsonPropertyName("systemstart")]
        public long? SystemStart { get; set; }

        [DataMember]
        [JsonPropertyName("activeslotcoeff")]
        public string? ActiveSlotCoeff { get; set; }

        [DataMember]
        [JsonPropertyName("slotsperkesperiod")]
        public string? SlotsPerKesPeriod { get; set; }

        [DataMember]
        [JsonPropertyName("maxkesrevolutions")]
        public string? MaxKesRevolutions { get; set; }

        [DataMember]
        [JsonPropertyName("securityparam")]
        public string? SecurityParam { get; set; }

        [DataMember]
        [JsonPropertyName("updatequorum")]
        public string? UpdateQuorum { get; set; }

        [DataMember]
        [JsonPropertyName("alonzogenesis")]
        public string? AlonzoGenesis { get; set; }
    }
}