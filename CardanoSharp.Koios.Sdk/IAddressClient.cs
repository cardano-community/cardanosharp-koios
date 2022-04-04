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
        Task<AddressInformation[]> GetAddressInformation([AliasAs("_address")] string address, int? limit = null, int? offset = null);

        [Post("/address_txs")]
        Task<AddressTransaction[]> GetAddressTransactions([Body] AddressTransactionRequest request, int? limit = null, int? offset = null);
        [Get("/address_assets")]
        Task<AddressAsset[]> GetAddressAssets([AliasAs("_address")] string address, int? limit = null, int? offset = null);

        [Post("/credential_txs")]
        Task<AddressTransaction[]> GetCredentialTransactions([Body] CredentialTransactionRequest request, int? limit = null, int? offset = null);
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