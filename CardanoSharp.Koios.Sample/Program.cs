// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using CardanoSharp.Koios.Sdk;
using Refit;

var networkClient = RestService.For<INetworkClient>("https://api.koios.rest/api/v0");
var epochClient = RestService.For<IEpochClient>("https://api.koios.rest/api/v0");
var blockClient = RestService.For<IBlockClient>("https://api.koios.rest/api/v0");
var transactionClient = RestService.For<ITransactionClient>("https://api.koios.rest/api/v0");
var addressClient = RestService.For<IAddressClient>("https://api.koios.rest/api/v0");

// Query Chain Tip
Console.WriteLine("Query Chain Tip");
var chainTip = networkClient.GetChainTip().Result;
string latestEpoch = "294";
foreach (var ct in chainTip)
{
    latestEpoch = ct.Epoch.ToString();
    Console.WriteLine(JsonSerializer.Serialize(ct));
}
Console.WriteLine();

// Get Genesis Info
Console.WriteLine("Get Genesis Info");
var genesisInfo = networkClient.GetGenesisInfo().Result;
foreach (var gi in genesisInfo)
{
    Console.WriteLine(JsonSerializer.Serialize(gi));
}
Console.WriteLine();

// Get Historical Tokenomic Stats
Console.WriteLine("Get Historical Tokenomic Stats");
var historicalStats = networkClient.GetHistoricalTokenomicStats(latestEpoch).Result;
foreach (var hs in historicalStats)
{
    Console.WriteLine(JsonSerializer.Serialize(hs));
}
Console.WriteLine();

// Get Epoch Information
Console.WriteLine("Get Epoch Information");
var epochInformations = epochClient.GetEpochInformation().Result;
foreach (var ei in epochInformations)
{
    Console.WriteLine(JsonSerializer.Serialize(ei));
}
Console.WriteLine();

// Get Epoch Information
Console.WriteLine("Get Protocol Parameters");
var protocolParameters = epochClient.GetProtocolParameters(latestEpoch).Result;
foreach (var pp in protocolParameters)
{
    Console.WriteLine(JsonSerializer.Serialize(pp));
}
Console.WriteLine();

// Get Block List
Console.WriteLine("Get Block List");
var blockList = blockClient.GetBlockList().Result;
foreach (var bl in blockList)
{
    Console.WriteLine(JsonSerializer.Serialize(bl));
}
Console.WriteLine();

// Get Block Information
Console.WriteLine("Get Block Information");
var blockHash = "f6192a1aaa6d3d05b4703891a6b66cd757801c61ace86cbe5ab0d66e07f601ab";
var blockInfo = blockClient.GetBlockInfo(blockHash).Result;
foreach (var bi in blockInfo)
{
    Console.WriteLine(JsonSerializer.Serialize(bi));
}
Console.WriteLine();

// Get Block Transactions
Console.WriteLine("Get Block Transactions");
var blockTransactions = blockClient.GetBlockTransactions(blockHash).Result;
foreach (var bt in blockTransactions)
{
    Console.WriteLine(JsonSerializer.Serialize(bt));
}
Console.WriteLine();


var transactionRequest = new GetTransactionRequest
{
    TxHashes = new List<string>()
    {
        "f144a8264acf4bdfe2e1241170969c930d64ab6b0996a4a45237b623f1dd670e",
        "0b8ba3bed976fa4913f19adc9f6dd9063138db5b4dd29cecde369456b5155e94"
    }
};

// Get Transaction Information
Console.WriteLine("Get Transaction Information");
var transactionInformation = transactionClient.GetTransactionInformation(transactionRequest).Result;
foreach (var ti in transactionInformation)
{
    Console.WriteLine(JsonSerializer.Serialize(ti));
}
Console.WriteLine();

// Get Transaction UTxOs
Console.WriteLine("Get Transaction UTxOs");
var transactionUtxos = transactionClient.GetTransactionUtxos(transactionRequest).Result;
foreach (var tu in transactionUtxos)
{
    Console.WriteLine(JsonSerializer.Serialize(tu));
}
Console.WriteLine();

// Get Transaction Metadata
Console.WriteLine("Get Transaction Metadata");
var transactionMetadata = transactionClient.GetTransactionMetadata(transactionRequest).Result;
foreach (var tm in transactionMetadata)
{
    Console.WriteLine(JsonSerializer.Serialize(tm));
}
Console.WriteLine();

// Get Transaction Metadata
Console.WriteLine("Get Transaction Status");
var transactionStatus = transactionClient.GetTransactionStatus(transactionRequest).Result;
foreach (var ts in transactionStatus)
{
    Console.WriteLine(JsonSerializer.Serialize(ts));
}
Console.WriteLine();

// Get Address Information
Console.WriteLine("Get Address Information");
var address = "addr1qyp9kz50sh9c53hpmk3l4ewj9ur794t2hdqpngsjn3wkc5sztv9glpwt3frwrhdrltjaytc8ut2k4w6qrx3p98zad3fq07xe9g";
var addressInformation = addressClient.GetAddressInformation(address).Result;
foreach (var ai in addressInformation)
{
    Console.WriteLine(JsonSerializer.Serialize(ai));
}
Console.WriteLine();

var addressTransactionRequest = new AddressTransactionRequest()
{
    Addresses = new List<string>()
    {
        "addr1qyp9kz50sh9c53hpmk3l4ewj9ur794t2hdqpngsjn3wkc5sztv9glpwt3frwrhdrltjaytc8ut2k4w6qrx3p98zad3fq07xe9g",
        "addr1qyfldpcvte8nkfpyv0jdc8e026cz5qedx7tajvupdu2724tlj8sypsq6p90hl40ya97xamkm9fwsppus2ru8zf6j8g9sm578cu"
    },
    AfterBlockHeight = 6238675
};

// Get Address Information
Console.WriteLine("Get Address Information");
var addressTransactions = addressClient.GetAddressTransactions(addressTransactionRequest).Result;
foreach (var at in addressTransactions)
{
    Console.WriteLine(JsonSerializer.Serialize(at));
}
Console.WriteLine();

var credentialTransactionRequest = new CredentialTransactionRequest()
{
    PaymentCredentials = new List<string>()
    {
        "025b0a8f85cb8a46e1dda3fae5d22f07e2d56abb4019a2129c5d6c52",
        "13f6870c5e4f3b242463e4dc1f2f56b02a032d3797d933816f15e555"
    },
    AfterBlockHeight = 6238675
};

// Get Transactions from payment credentials
Console.WriteLine("Get Transactions from payment credentials");
var credentialTransactions = addressClient
    .GetCredentialTransactions(credentialTransactionRequest).Result;
foreach (var ct in credentialTransactions)
{
    Console.WriteLine(JsonSerializer.Serialize(ct));
}
Console.WriteLine();
