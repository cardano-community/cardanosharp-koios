using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IAssetClient
    {
        [Get("/asset_list")]
        Task<ApiResponse<Asset[]>> GetAssetsList(
        [AliasAs("limit")] int? limit = null,
        [AliasAs("offset")] int? offset = null,
        [Header("Prefer")] string prefer = null);

        [Get("/asset_address_list")]
        Task<ApiResponse<AssetAddress[]>> GetAddresses([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string prefer = null);

        [Get("/asset_info")]
        Task<ApiResponse<AssetInformation[]>> GetInfo([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string prefer = null);

        [Get("/asset_txs")]
        Task<ApiResponse<AssetTransaction[]>> GetTransactions([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string prefer = null);
    }
}