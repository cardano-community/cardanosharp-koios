using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IAccountClient
    {
        [Get("/account_list")]
        Task<StakeAccount[]> GetAllStakeAccounts(int? limit = null, int? offset = null);

        [Get("/account_info")]
        Task<StakeInformation[]> GetStakeInformation([AliasAs("_address")] string address, int? limit = null, int? offset = null);

        [Get("/account_rewards")]
        Task<StakeReward[]> GetStakeRewards([AliasAs("_stake_address")] string address, 
            [AliasAs("_epoch_no")]string? epochNo = null, int? limit = null, int? offset = null);

        [Get("/account_updates")]
        Task<StakeUpdate[]> GetStakeUpdates([AliasAs("_stake_address")] string address, int? limit = null, int? offset = null);

        [Get("/account_addresses")]
        Task<StakeAddress[]> GetStakeAddresses([AliasAs("_address")] string address, int? limit = null, int? offset = null);

        [Get("/account_assets")]
        Task<StakeAsset[]> GetStakeAssets([AliasAs("_address")] string address, [AliasAs("asset_name")] string assetName = null, [AliasAs("asset_policy")] string assetPolicy = null, int? limit = null, int? offset = null);

        [Get("/account_history")]
        Task<StakeHistory[]> GetStakeHistory([AliasAs("_address")] string address, int? limit = null, int? offset = null);
    }
}