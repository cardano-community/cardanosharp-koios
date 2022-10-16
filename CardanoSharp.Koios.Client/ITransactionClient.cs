using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Client.Contracts;
using Refit;

namespace CardanoSharp.Koios.Client
{
    public interface ITransactionClient
    {
        [Post("/tx_info")]
        Task<ApiResponse<Transaction[]>> GetTransactionInformation([Body] GetTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Post("/tx_utxos")]
        Task<ApiResponse<Transaction[]>> GetTransactionUtxos([Body] GetTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Post("/tx_metadata")]
        Task<ApiResponse<TransactionMetadata[]>> GetTransactionMetadata([Body] GetTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Post("/tx_status")]
        Task<ApiResponse<TransactionStatus[]>> GetTransactionStatus([Body] GetTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Headers("Content-Type: application/cbor")]
        [Post("/submittx")]
        Task<ApiResponse<string>> Submit([Body] Stream request);
    }

    public class GetTransactionRequest
    {
        [JsonPropertyName("_tx_hashes")] public List<string>? TxHashes { get; set; }
    }
}