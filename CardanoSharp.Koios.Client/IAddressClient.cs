using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Client.Contracts;
using Refit;

namespace CardanoSharp.Koios.Client
{
    public interface IAddressClient
    {
        [Post("/address_info")]
        Task<ApiResponse<AddressInformation[]>> GetAddressInformation([Body] AddressBulkRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
        
        [Post("/address_utxos")]
        Task<ApiResponse<AddressUtxo[]>> GetAddressUtxos([Body] AddressUtxoRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null,
            [Header("Prefer")] string? prefer = null);
        
        [Post("/credential_utxos")]
        Task<ApiResponse<AddressUtxo[]>> GetCredentialUtxos([Body] GetCredentialUtxosRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null,
            [Header("Prefer")] string? prefer = null);

        [Post("/address_txs")]
        Task<ApiResponse<AddressTransaction[]>> GetAddressTransactions([Body] AddressTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/address_assets")]
        Task<ApiResponse<AddressAssetGroup[]>> GetAddressAssets([Body] AddressBulkRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);

        [Post("/credential_txs")]
        Task<ApiResponse<AddressTransaction[]>> GetCredentialTransactions([Body] CredentialTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string? prefer = null);
    }

    public class AddressBulkRequest
    {
        [JsonPropertyName("_addresses")]
        public string[]? Addresses { get; set; }
    }

    public class AddressUtxoRequest
    {
        [JsonPropertyName("_addresses")]
        public string[]? Addresses { get; set; }

        [JsonPropertyName("_extended")]
        public bool Extended { get; set; }
    }

    public class AddressTransactionRequest
    {
        [JsonPropertyName("_addresses")] 
        public string[]? Addresses { get; set; }
        
        [JsonPropertyName("_after_block_height")]
        public uint AfterBlockHeight { get; set; }
    }
    
    public class GetCredentialUtxosRequest
    {
        [JsonPropertyName("_payment_credentials")] 
        public string[]? PaymentCredentials { get; set; }
        
        [JsonPropertyName("_extended")]
        public bool Extended { get; set; }
    }

    public class CredentialTransactionRequest
    {
        [JsonPropertyName("_payment_credentials")] 
        public string[]? PaymentCredentials { get; set; }
        
        [JsonPropertyName("_after_block_height")]
        public uint AfterBlockHeight { get; set; }
    }
}