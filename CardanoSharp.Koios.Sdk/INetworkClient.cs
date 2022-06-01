﻿using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface INetworkClient
    {
        [Get("/tip")]
        Task<ApiResponse<BlockSummary[]>> GetChainTip();

        [Get("/genesis")]
        Task<ApiResponse<GenesisParameters[]>> GetGenesisInfo();

        [Get("/totals")]
        Task<ApiResponse<TokenomicStats[]>> GetHistoricalTokenomicStats([AliasAs("_epoch_no")] string epoch, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
    }
}