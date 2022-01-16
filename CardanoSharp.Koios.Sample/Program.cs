// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using CardanoSharp.Koios.Sdk;
using Refit;

var networkClient = RestService.For<INetworkClient>("https://api.koios.rest/api/v0");
var epochClient = RestService.For<IEpochClient>("https://api.koios.rest/api/v0");
var blockClient = RestService.For<IBlockClient>("https://api.koios.rest/api/v0");
var transactionClient = RestService.For<ITransactionClient>("https://api.koios.rest/api/v0");

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