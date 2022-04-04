using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IScriptClient
    {
        [Get("/native_script_list")]
        Task<ScriptItem[]> GetNativeList(int? limit = null, int? offset = null);
        [Get("/plutus_script_list")]
        Task<ScriptItem[]> GetPlutusList(int? limit = null, int? offset = null);

        [Get("/script_redeemers")]
        Task<ScriptRedeemer[]> GetRedeemers([AliasAs("_script_hash")] string scriptHash, int? limit = null, int? offset = null);
    }
}
