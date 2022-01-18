using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IAccountClient
    {
        [Get("/account_list")]
        Task<StakeAccount[]> GetAllStakeAccounts();

        [Get("/account_info?_address={address}")]
        Task<StakeInformation[]> GetStakeInformation(string address);

        [Get("/account_rewards?_stake_address={address}")]
        Task<StakeReward[]> GetStakeRewards(string address, [AliasAs("_epoch_no")]string? epochNo = null);

        [Get("/account_updates?_stake_address={address}")]
        Task<StakeUpdate[]> GetStakeUpdates(string address);

        [Get("/account_addresses?_address={address}")]
        Task<StakeAddress[]> GetStakeAddresses(string address);

        [Get("/account_assets?_address={address}")]
        Task<StakeAsset[]> GetStakeAssets(string address);

        [Get("/account_history?_address={address}")]
        Task<StakeHistory[]> GetStakeHistory(string address);
    }
}