using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Client.Contracts;
using Refit;

namespace CardanoSharp.Koios.Client
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

        [Post("/datum_info")]
        Task<ApiResponse<DatumInformation[]>> GetDatumInformation([Body] GetDatumInformationRequest request,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null,
            [Header("Prefer")] string? prefer = null);
    }

    public class GetDatumInformationRequest
    {
        [JsonPropertyName("_datum_hashes")]
        public IEnumerable<string>? DatumHashes { get; set; }
    }
}
