using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IScriptClient
    {
        [Get("/script_list")]
        Task<ScriptItem[]> GetList(int? limit = null, int? offset = null);

        [Get("/script_redeemers")]
        Task<ScriptRedeemer[]> GetRedeemers([AliasAs("_script_hash")] string scriptHash, int? limit = null, int? offset = null);
    }
}