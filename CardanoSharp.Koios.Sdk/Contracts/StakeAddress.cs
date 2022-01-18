using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class StakeAddress
    {
        [DataMember]
        [JsonPropertyName("address")]
        public string? Address { get; set; }
    }
}