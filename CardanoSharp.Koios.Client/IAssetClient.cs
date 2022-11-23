using System.Threading.Tasks;
using CardanoSharp.Koios.Client.Contracts;
using Refit;

namespace CardanoSharp.Koios.Client
{
    public interface IAssetClient
    {
        [Get("/asset_list")]
        Task<ApiResponse<Asset[]>> GetAssetsList(
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/asset_address_list")]
        Task<ApiResponse<AssetAddress[]>> GetAddresses([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/asset_info")]
        Task<ApiResponse<AssetInformation[]>> GetInfo([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/asset_history")]
        Task<ApiResponse<AssetHistory[]>> GetHistory([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/asset_policy_info")]
        Task<ApiResponse<AssetPolicyInfo[]>> GetPolicyInfo([AliasAs("_asset_policy")] string policyId,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/asset_summary")]
        Task<ApiResponse<AssetSummary[]>> GetSummary([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Get("/asset_txs")]
        Task<ApiResponse<AssetTransaction[]>> GetTransactions([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName = null,
            [AliasAs("_after_block_height")] uint? afterBlockHeight = null,
            [AliasAs("_history")] bool? history = false,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);
    }
}