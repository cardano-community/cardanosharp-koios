using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IEpochClient
    {
        [Get("/epoch_info")]
        Task<EpochInformation[]> GetEpochInformation(int? limit = null, int? offset = null);
        
        [Get("/epoch_params")]
        Task<ProtocolParameters[]> GetProtocolParameters([AliasAs("_epoch_no")] string epoch, int? limit = null, int? offset = null);
    }
}