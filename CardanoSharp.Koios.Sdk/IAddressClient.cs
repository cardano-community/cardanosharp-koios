using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardanoSharp.Koios.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Koios.Sdk
{
    public interface IAddressClient
    {
        [Get("/address_info?_address={address}")]
        Task<AddressInformation[]> GetAddressInformation(string address);

        [Post("/address_txs")]
        Task<AddressTransaction[]> GetAddressTransactions([Body] AddressTransactionRequest request);

        [Post("/credential_txs")]
        Task<AddressTransaction[]> GetCredentialTransactions([Body] CredentialTransactionRequest request);
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