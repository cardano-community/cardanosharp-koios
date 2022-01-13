using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts;

[DataContract]
public class TokenomicStats
{
    [DataMember]
    [JsonPropertyName("epoch_no")]
    public uint EpochNo { get; set; }
    
    [DataMember]
    [JsonPropertyName("circulation")]
    public ulong Circulation { get; set; }
    
    [DataMember]
    [JsonPropertyName("treasury")]
    public ulong Treasury { get; set; }
    
    [DataMember]
    [JsonPropertyName("reward")]
    public ulong Reward { get; set; }
    
    [DataMember]
    [JsonPropertyName("supply")]
    public ulong Supply { get; set; }
    
    [DataMember]
    [JsonPropertyName("reserves")]
    public ulong Reserves { get; set; }
}