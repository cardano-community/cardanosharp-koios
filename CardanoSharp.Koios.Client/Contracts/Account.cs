using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class Account
    {
        [DataMember]
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}