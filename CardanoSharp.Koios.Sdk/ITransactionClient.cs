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
        Task<Transaction[]> GetTransactionInformation([Body] GetTransactionRequest request);
        
        [Post("/tx_utxos")]
        Task<Transaction[]> GetTransactionUtxos([Body] GetTransactionRequest request);
        
        [Post("/tx_metadata")]
        Task<TransactionMetadata[]> GetTransactionMetadata([Body] GetTransactionRequest request);
    }

    public class GetTransactionRequest
    {
        [JsonPropertyName("_tx_hashes")] public List<string> TxHashes { get; set; }
    }
}