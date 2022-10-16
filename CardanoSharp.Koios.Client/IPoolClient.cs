using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Client.Contracts;
using Refit;

namespace CardanoSharp.Koios.Client
{
    public interface IPoolClient
    {
        [Get("/pool_list")]
        Task<ApiResponse<PoolItem[]>> GetList([AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/pool_info")]
        Task<ApiResponse<PoolInformation[]>> GetInformation([Body] PoolInformationRequest poolBech32, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Get("/pool_stake_snapshot")]
        Task<ApiResponse<PoolStakeSnapshot[]>> GetStakeSnapshot([AliasAs("_pool_bech32")] string poolBech32,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/pool_delegators")]
        Task<ApiResponse<PoolDelegator[]>> GetDelegators([AliasAs("_pool_bech32")] string poolBech32,
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Get("/pool_delegators_history")]
        Task<ApiResponse<PoolDelegatorHistory[]>> GetDelegatorsHistory([AliasAs("_pool_bech32")] string poolBech32,
            [AliasAs("_epoch_no")] string? epochNo = null,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/pool_blocks")]
        Task<ApiResponse<PoolBlock[]>> GetBlocks([AliasAs("_pool_bech32")] string poolBech32,
            [AliasAs("_epoch_no")] string epochNo, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Get("/pool_history")]
        Task<ApiResponse<PoolHistory[]>> GetHistory([AliasAs("_pool_bech32")] string poolBech32,
            [AliasAs("_epoch_no")] string epochNo,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/pool_updates")]
        Task<ApiResponse<PoolUpdate[]>> GetUpdates([AliasAs("_pool_bech32")] string poolBech32, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Get("/pool_relays")]
        Task<ApiResponse<PoolRelay[]>> GetRelays([AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Get("/pool_metadata")]
        Task<ApiResponse<PoolMetadata[]>> GetMetadata([AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
    }

    public class PoolInformationRequest
    {
        [JsonPropertyName("_pool_bech32_ids")]
        public List<string>? PoolBech32Ids { get; set; }
    }
}