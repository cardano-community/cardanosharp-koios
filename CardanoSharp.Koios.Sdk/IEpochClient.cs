using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IEpochClient
    {
        [Get("/epoch_info")]
        Task<EpochInformation[]> GetEpochInformation();
        
        [Get("/epoch_params?_epoch_no={epoch}")]
        Task<ProtocolParameters[]> GetProtocolParameters(string epoch);
    }
}