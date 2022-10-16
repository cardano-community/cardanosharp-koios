using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Client.Contracts
{
    [DataContract]
    public class AccountAddressGroup
    {
        [DataMember]
        [JsonPropertyName("stake_address")]
        public string? StakeAddress { get; set; }

        [DataMember]
        [JsonPropertyName("addresses")]
        public string[]? Addresses { get; set; }
    }
}