using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface ITransactionClient
    {
        [Post("/tx_info")]
        Task<Transaction[]> GetTransactionInformation([Body] GetTransactionRequest request, int? limit = null, int? offset = null);
        
        [Post("/tx_utxos")]
        Task<Transaction[]> GetTransactionUtxos([Body] GetTransactionRequest request, int? limit = null, int? offset = null);
        
        [Post("/tx_metadata")]
        Task<TransactionMetadata[]> GetTransactionMetadata([Body] GetTransactionRequest request, int? limit = null, int? offset = null);
        
        [Post("/tx_status")]
        Task<TransactionStatus[]> GetTransactionStatus([Body] GetTransactionRequest request, int? limit = null, int? offset = null);
    }

    public class GetTransactionRequest
    {
        [JsonPropertyName("_tx_hashes")] public List<string> TxHashes { get; set; }
    }
}