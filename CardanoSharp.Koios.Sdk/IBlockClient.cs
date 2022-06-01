using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IBlockClient
    {
        [Get("/blocks")]
        Task<ApiResponse<Block[]>> GetBlockList([AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
        
        [Post("/block_info")]
        Task<ApiResponse<Block[]>> GetBlockInfo([Body] GetBlockInformationRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
        
        [Get("/block_txs")]
        Task<ApiResponse<BlockTransaction[]>> GetBlockTransactions([AliasAs("_block_hash")] string blockHash, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
    }   
    
    public class GetBlockInformationRequest
    {
        [JsonPropertyName("_block_hashes")]
        public string[] BlockHashes { get; set; }
    }
}