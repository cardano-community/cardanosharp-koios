using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IAddressClient
    {
        [Get("/address_info")]
        Task<ApiResponse<AddressInformation[]>> GetAddressInformation([AliasAs("_address")] string address, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);

        [Post("/address_txs")]
        Task<ApiResponse<AddressTransaction[]>> GetAddressTransactions([Body] AddressTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
        [Get("/address_assets")]
        Task<ApiResponse<AddressAsset[]>> GetAddressAssets([AliasAs("_address")] string address, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);

        [Post("/credential_txs")]
        Task<ApiResponse<AddressTransaction[]>> GetCredentialTransactions([Body] CredentialTransactionRequest request, 
            [AliasAs("limit")]int? limit = null, 
            [AliasAs("offset")]int? offset = null, 
            [Header("Prefer")] string prefer = null);
    }

    public class AddressTransactionRequest
    {
        [JsonPropertyName("_addresses")] 
        public List<string> Addresses { get; set; }
        
        [JsonPropertyName("_after_block_height")]
        public uint AfterBlockHeight { get; set; }
    }

    public class CredentialTransactionRequest
    {
        [JsonPropertyName("_payment_credentials")] 
        public List<string> PaymentCredentials { get; set; }
        
        [JsonPropertyName("_after_block_height")]
        public uint AfterBlockHeight { get; set; }
    }
}