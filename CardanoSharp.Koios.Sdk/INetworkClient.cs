using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface INetworkClient
    {
        [Get("/tip")]
        Task<BlockSummary[]> GetChainTip();

        [Get("/genesis")]
        Task<GenesisParameters[]> GetGenesisInfo();

        [Get("/totals")]
        Task<TokenomicStats[]> GetHistoricalTokenomicStats([AliasAs("_epoch_no")] string epoch, int? limit = null, int? offset = null);
    }
}