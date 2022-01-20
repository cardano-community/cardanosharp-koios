using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IAssetClient
    {
        [Get("/asset_address_list")]
        Task<AssetAddress[]> GetAddresses([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName, int? limit = null, int? offset = null);
        
        [Get("/asset_info")]
        Task<AssetInformation[]> GetInfo([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName, int? limit = null, int? offset = null);
        
        [Get("/asset_txs")]
        Task<AssetTransaction[]> GetTransactions([AliasAs("_asset_policy")] string policyId,
            [AliasAs("_asset_name")] string assetName, int? limit = null, int? offset = null);
    }
}