using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk;

public interface INetworkClient
{
    [Get("/tip")]
    Task<BlockSummary[]> GetChainTip();

    [Get("/genesis")]
    Task<GenesisParameters[]> GetGenesisInfo();

    [Get("/totals?_epoch_no={epoch}")]
    Task<TokenomicStats[]> GetHistoricalTokenomicStats(string epoch);
}