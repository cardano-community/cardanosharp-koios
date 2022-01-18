using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class StakeAccount
    {
        [DataMember]
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}