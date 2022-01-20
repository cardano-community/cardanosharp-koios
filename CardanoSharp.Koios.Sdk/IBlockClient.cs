using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IBlockClient
    {
        [Get("/blocks")]
        Task<Block[]> GetBlockList(int? limit = null, int? offset = null);
        
        [Get("/block_info")]
        Task<Block[]> GetBlockInfo([AliasAs("_block_hash")] string blockHash, int? limit = null, int? offset = null);
        
        [Get("/block_txs")]
        Task<BlockTransaction[]> GetBlockTransactions([AliasAs("_block_hash")] string blockHash, int? limit = null, int? offset = null);
    }
}