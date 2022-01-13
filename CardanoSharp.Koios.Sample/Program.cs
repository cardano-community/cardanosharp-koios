// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using CardanoSharp.Koios.Sdk;
using Refit;

var koios = RestService.For<INetworkClient>("https://api.koios.rest/api/v0");

// Query Chain Tip
Console.WriteLine("Query Chain Tip");
var chainTip = koios.GetChainTip().Result;
string latestEpoch = "294";
foreach (var ct in chainTip)
{
    latestEpoch = ct.Epoch.ToString();
    Console.WriteLine(JsonSerializer.Serialize(ct));
}
Console.WriteLine();

// Get Genesis Info
Console.WriteLine("Get Genesis Info");
var genesisInfo = koios.GetGenesisInfo().Result;
foreach (var gi in genesisInfo)
{
    Console.WriteLine(JsonSerializer.Serialize(gi));
}
Console.WriteLine();

// Get Historical Tokenomic Stats
Console.WriteLine("Get Historical Tokenomic Stats");
var historicalStats = koios.GetHistoricalTokenomicStats(latestEpoch).Result;
foreach (var hs in historicalStats)
{
    Console.WriteLine(JsonSerializer.Serialize(hs));
}
Console.WriteLine();