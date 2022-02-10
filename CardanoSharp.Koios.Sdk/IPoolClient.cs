using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IPoolClient
    {
        [Get("/pool_list")]
        Task<PoolItem[]> GetList(int? limit = null, int? offset = null);

        [Post("/pool_info")]
        Task<PoolInformation[]> GetInformation([Body] PoolInformationRequest poolBech32, int? limit = null, int? offset = null);

        [Get("/pool_delegators")]
        Task<PoolDelegator[]> GetDelegators([AliasAs("_pool_bech32")] string poolBech32,
            [AliasAs("_epoch_no")] string? epochNo = null, int? limit = null, int? offset = null);

        [Get("/pool_blocks")]
        Task<PoolBlock[]> GetBlocks([AliasAs("_pool_bech32")] string poolBech32,
            [AliasAs("_epoch_no")] string epochNo, int? limit = null, int? offset = null);

        [Get("/pool_updates")]
        Task<PoolUpdate[]> GetUpdates([AliasAs("_pool_bech32")] string poolBech32, int? limit = null, int? offset = null);
        
        [Get("/pool_relays")]
        Task<PoolRelay[]> GetRelays(int? limit = null, int? offset = null);
        
        [Get("/pool_metadata")]
        Task<PoolMetadata[]> GetMetadata(int? limit = null, int? offset = null);
    }

    public class PoolInformationRequest
    {
        [JsonPropertyName("_pool_bech32_ids")]
        public List<string> PoolBech32Ids { get; set; }
    }
}