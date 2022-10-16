using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Client.Contracts;
using Refit;

namespace CardanoSharp.Koios.Client
{
    public interface IAccountClient
    {
        [Get("/account_list")]
        Task<ApiResponse<Account[]>> GetAllAccounts([AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/account_info")]
        Task<ApiResponse<AccountInformation[]>> GetAccountInformation([Body]AccountBulkRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/account_rewards")]
        Task<ApiResponse<AccountRewardGroup[]>> GetAccountRewards([Body] AccountHistoricalBulkRequest request,
            [AliasAs("_epoch_no")]string? epochNo = null, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/account_updates")]
        Task<ApiResponse<AccountUpdateGroup[]>> GetAccountUpdates([Body] AccountBulkRequest request,
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/account_addresses")]
        Task<ApiResponse<AccountAddressGroup[]>> GetAccountAddresses([Body] AccountBulkRequest request,
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/account_assets")]
        Task<ApiResponse<AccountAssetGroup[]>> GetAccountAssets([Body] AccountBulkRequest request,
            [AliasAs("asset_name")] string assetName = null, 
            [AliasAs("asset_policy")] string assetPolicy = null, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/account_history")]
        Task<ApiResponse<AccountHistoryGroup[]>> GetAccountHistory([Body] AccountHistoricalBulkRequest request,
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
    }

    public class AccountBulkRequest
    {
        [JsonPropertyName("_stake_addresses")]
        public string[]? StakeAddresses { get; set; }
    }

    public class AccountHistoricalBulkRequest
    {
        [JsonPropertyName("_stake_addresses")]
        public string[]? StakeAddresses { get; set; }

        [JsonPropertyName("_epoch_no")]
        public uint EpochNo { get; set; }
    }
}