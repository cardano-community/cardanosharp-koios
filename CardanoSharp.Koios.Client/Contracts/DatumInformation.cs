using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class DatumInformation
    {
        [DataMember]
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }

        [DataMember]
        [JsonPropertyName("value")]
        public object? Value { get; set; }

        [DataMember]
        [JsonPropertyName("bytes")]
        public string? Bytes { get; set; }
    }
}