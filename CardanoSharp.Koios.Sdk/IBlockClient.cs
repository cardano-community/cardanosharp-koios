using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IBlockClient
    {
        [Get("/blocks")]
        Task<Block[]> GetBlockList();
        
        [Get("/block_info?_block_hash={blockHash}")]
        Task<Block[]> GetBlockInfo(string blockHash);
        
        [Get("/block_txs?_block_hash={blockHash}")]
        Task<BlockTransaction[]> GetBlockTransactions(string blockHash);
    }
}