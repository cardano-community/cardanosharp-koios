using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IAccountClient
    {
        [Get("/account_list")]
        Task<ApiResponse<StakeAccount[]>> GetAllStakeAccounts([AliasAs("limit")]int? limit = null, 
        [AliasAs("offset")]int? offset = null, 
        [Header("Prefer")] string prefer = null);

        [Get("/account_info")]
        Task<ApiResponse<StakeInformation[]>> GetStakeInformation([AliasAs("_address")] string address, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);

        [Get("/account_rewards")]
        Task<ApiResponse<StakeReward[]>> GetStakeRewards([AliasAs("_stake_address")] string address, 
            [AliasAs("_epoch_no")]string? epochNo = null, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);

        [Get("/account_updates")]
        Task<ApiResponse<StakeUpdate[]>> GetStakeUpdates([AliasAs("_stake_address")] string address, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);

        [Get("/account_addresses")]
        Task<ApiResponse<StakeAddress[]>> GetStakeAddresses([AliasAs("_address")] string address, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);

        [Get("/account_assets")]
        Task<ApiResponse<StakeAsset[]>> GetStakeAssets([AliasAs("_address")] string address, 
            [AliasAs("asset_name")] string assetName = null, 
            [AliasAs("asset_policy")] string assetPolicy = null, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);

        [Get("/account_history")]
        Task<ApiResponse<StakeHistory[]>> GetStakeHistory([AliasAs("_address")] string address, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
    }
}