using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IScriptClient
    {
        [Get("/native_script_list")]
        Task<ApiResponse<ScriptItem[]>> GetNativeList([AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Get("/plutus_script_list")]
        Task<ApiResponse<ScriptItem[]>> GetPlutusList([AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Get("/script_redeemers")]
        Task<ApiResponse<ScriptRedeemer[]>> GetRedeemers([AliasAs("_script_hash")] string scriptHash, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
    }
}
