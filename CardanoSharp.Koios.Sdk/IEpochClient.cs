using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IEpochClient
    {
        [Get("/epoch_info")]
        Task<ApiResponse<EpochInformation[]>> GetEpochInformation([AliasAs("_epoch_no")] string? epochNo = null, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
        
        [Get("/epoch_params")]
        Task<ApiResponse<ProtocolParameters[]>> GetProtocolParameters([AliasAs("_epoch_no")] string? epochNo = null, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
    }
}