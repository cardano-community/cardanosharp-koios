using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IBlockClient
    {
        [Get("/blocks")]
        Task<Block[]> GetBlockList(int? limit = null, int? offset = null);
        
        [Post("/block_info")]
        Task<Block[]> GetBlockInfo([Body] GetBlockInformationRequest request, int? limit = null, int? offset = null);
        
        [Get("/block_txs")]
        Task<BlockTransaction[]> GetBlockTransactions([AliasAs("_block_hash")] string blockHash, int? limit = null, int? offset = null);
    }   
    
    public class GetBlockInformationRequest
    {
        [JsonPropertyName("_block_hashes")]
        public string[] BlockHashes { get; set; }
    }
}