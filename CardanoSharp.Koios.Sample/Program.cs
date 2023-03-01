// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using CardanoSharp.Koios.Client;
using Refit;

var networkClient = RestService.For<INetworkClient>("https://api.koios.rest/api/v0");
var epochClient = RestService.For<IEpochClient>("https://api.koios.rest/api/v0");
var blockClient = RestService.For<IBlockClient>("https://api.koios.rest/api/v0");
var transactionClient = RestService.For<ITransactionClient>("https://api.koios.rest/api/v0");
var addressClient = RestService.For<IAddressClient>("https://api.koios.rest/api/v0");
var accountClient = RestService.For<IAccountClient>("https://api.koios.rest/api/v0");
var assetClient = RestService.For<IAssetClient>("https://api.koios.rest/api/v0");
var poolClient = RestService.For<IPoolClient>("https://api.koios.rest/api/v0");
var scriptClient = RestService.For<IScriptClient>("https://api.koios.rest/api/v0");

// Query Chain Tip
Console.WriteLine("Query Chain Tip");
var chainTip = networkClient.GetChainTip().Result;
string latestEpoch = "369";
foreach (var ct in chainTip.Content)
{
    latestEpoch = ct.Epoch.ToString();
    Console.WriteLine(JsonSerializer.Serialize(ct));
}
Console.WriteLine();

// Get Genesis Info
Console.WriteLine("Get Genesis Info");
var genesisInfo = networkClient.GetGenesisInfo().Result;
foreach (var gi in genesisInfo.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(gi));
}
Console.WriteLine();

// Get Historical Tokenomic Stats
Console.WriteLine("Get Historical Tokenomic Stats");
var historicalStats = networkClient.GetHistoricalTokenomicStats(latestEpoch).Result;
foreach (var hs in historicalStats.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(hs));
}
Console.WriteLine();

// Get Epoch Information
Console.WriteLine("Get Epoch Information");
var epochInformations = epochClient.GetEpochInformation().Result;
foreach (var ei in epochInformations.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(ei));
}
Console.WriteLine();

// Get Epoch Information
Console.WriteLine("Get Protocol Parameters");
var protocolParameters = epochClient.GetProtocolParameters(latestEpoch).Result;
foreach (var pp in protocolParameters.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pp));
}
Console.WriteLine();

// Get Epoch Information
Console.WriteLine("Get Block Protocol");
var blockProtocol = epochClient.GetEpochsBlockProtocols(latestEpoch).Result;
foreach (var eb in blockProtocol.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(eb));
}
Console.WriteLine();

// Get Block List
Console.WriteLine("Get Block List");
var blockList = blockClient.GetBlockList().Result;
foreach (var bl in blockList.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(bl));
}
Console.WriteLine();

// Get Block Information
Console.WriteLine("Get Block Information");
var blockHashes = new string[] { "f6192a1aaa6d3d05b4703891a6b66cd757801c61ace86cbe5ab0d66e07f601ab" };
var getBlockInfoRequest = new BlockBulkRequest() { BlockHashes = blockHashes };
var blockInfo = blockClient.GetBlockInfo(getBlockInfoRequest).Result;
foreach (var bi in blockInfo.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(bi));
}
Console.WriteLine();

// Get Block Transactions
Console.WriteLine("Get Block Transactions");
var blockTransactions = blockClient.GetBlockTransactions(new BlockBulkRequest { BlockHashes = blockHashes }).Result;
foreach (var bt in blockTransactions.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(bt));
}
Console.WriteLine();

// Get Transaction Information
Console.WriteLine("Get Transaction Information");
var transactionRequest = new GetTransactionRequest
{
    TxHashes = new List<string>()
    {
        "1be5e0c09cb4ff238e00717fcce4f01acc286f7b4595d44334c8b911b6ce600b"
    }
};
var transactionInformation = transactionClient.GetTransactionInformation(transactionRequest).Result;
foreach (var ti in transactionInformation.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(ti));
}
Console.WriteLine();

// Get Transaction UTxOs
Console.WriteLine("Get Transaction UTxOs");
var transactionUtxos = transactionClient.GetTransactionUtxos(transactionRequest).Result;
foreach (var tu in transactionUtxos.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(tu));
}
Console.WriteLine();

// Get Transaction Metadata
Console.WriteLine("Get Transaction Metadata");
var transactionMetadata = transactionClient.GetTransactionMetadata(transactionRequest).Result;
foreach (var tm in transactionMetadata.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(tm));
}
Console.WriteLine();

//Get Transaction Metadata
Console.WriteLine("Get Transaction Status");
var transactionStatus = transactionClient.GetTransactionStatus(transactionRequest).Result;
foreach (var ts in transactionStatus.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(ts));
}
Console.WriteLine();

//Submit Transaction Example
//this produced this https://testnet.cardanoscan.io/transaction/3e30d5012bdea1ffa667f0dbbac647ef5b74acb0c747af89657cc9456ad39df7
// var txId = string.Empty;
// string signedTxStr = "83a6008182582084c204d1a649fa8fe0a7d50989465baf71d2a371a886d1344395b8316bd3abfb00018282583900550c1b4b5deeea285479bbbc331d78220dc813b3636808186fad1b2154a7f74869944ecbe91d8e8de2642c172c620520cda6d3d29cdbfa48821a001e8480a1581c4d3b2796fd8b9b2242699b1dd1c6aa5e079bd2ceb084aeba664cbfeda14d53686172704e6f7465626f6f6b0182583900ff13307529d67cc23a1bde15c67c2f1410ecfcbb1b03fbe11cd26920e0094f2b527fd1c46d28f707b01a5566876137a4fd62cc0740fb6c4e1a0076d6b3021a00033b4d031a035ec095075820b9cd4185d6dec9954c6534c63aac48dfa540de027c647e7d5a1e39b661d091c809a1581c4d3b2796fd8b9b2242699b1dd1c6aa5e079bd2ceb084aeba664cbfeda14d53686172704e6f7465626f6f6b01a20082825820ec96948e3dc78e245ba9fd57c91dc4099c36be848e3d9a593b202ef01d2c47e65840ea0f581b8d712fad1b0c5723048d27b5f4e49fc63e4c9c55545a4156c1f754ad34b74195adb8d89cbaef0bc11d7123a5e3cbcb2f91a412f8b073cba13a86c70482582095a193e076285356c3a8294f4e6c22e5d2023af48ca672ba7e18af4788ccd563584036acf806251117254b945b6b6ca40d18074e923158f4fc18ac8bad8ef861277c3785cb06d82cda613d3d8ca9d152bafbdd36293ad783471108ea31aae9e7a90a01818201818200581c39cb1fd8aa0778a0ac171eaf6e4e4f945516efa429a77611c3fa7f1e82a1190539a2657469746c65782043617264616e6f5368617270204b6f696f73205478205375626d697373696f6e676d657373616765781f43617264616e6f5368617270202b204b6f696f73203d20537563636573732180";
// byte[] signedTx = signedTxStr.HexToByteArray();
// try
// {
//     using (MemoryStream stream = new MemoryStream(signedTx))
//         txId = await transactionClient.Submit(stream);
// }
// catch(Exception e)
// {
//     txId = e.Message;
// }

// Get Address Information
Console.WriteLine("Get Address Information");
var address = "addr1qyp9kz50sh9c53hpmk3l4ewj9ur794t2hdqpngsjn3wkc5sztv9glpwt3frwrhdrltjaytc8ut2k4w6qrx3p98zad3fq07xe9g";
var addressBulkRequest = new AddressBulkRequest { Addresses = new List<string> { address } };
var addressInformation = addressClient.GetAddressInformation(addressBulkRequest).Result;
foreach (var ai in addressInformation.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(ai));
}
Console.WriteLine();

// Get Address Transactions
Console.WriteLine("Get Address Transactions");
var addressTransactionRequest = new AddressTransactionRequest()
{
    Addresses = new List<string>()
    {
        "addr1qyp9kz50sh9c53hpmk3l4ewj9ur794t2hdqpngsjn3wkc5sztv9glpwt3frwrhdrltjaytc8ut2k4w6qrx3p98zad3fq07xe9g",
        "addr1qyfldpcvte8nkfpyv0jdc8e026cz5qedx7tajvupdu2724tlj8sypsq6p90hl40ya97xamkm9fwsppus2ru8zf6j8g9sm578cu"
    },
    AfterBlockHeight = 6238675
};
var addressTransactions = addressClient.GetAddressTransactions(addressTransactionRequest).Result;
foreach (var at in addressTransactions.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(at));
}
Console.WriteLine();

// Get Address Assets
Console.WriteLine("Get Address Assets");
var addressAssets = addressClient.GetAddressAssets(addressBulkRequest).Result;
foreach (var aa in addressAssets.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(aa));
}
Console.WriteLine();

// Get Transactions from Payment Credentials
Console.WriteLine("Get Transactions from payment credentials");
var credentialTransactionRequest = new CredentialTransactionRequest()
{
    PaymentCredentials = new List<string>()
    {
        "025b0a8f85cb8a46e1dda3fae5d22f07e2d56abb4019a2129c5d6c52",
        "13f6870c5e4f3b242463e4dc1f2f56b02a032d3797d933816f15e555"
    },
    AfterBlockHeight = 6238675
};
var credentialTransactions = addressClient
    .GetCredentialTransactions(credentialTransactionRequest).Result;
foreach (var ct in credentialTransactions.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(ct));
}
Console.WriteLine();

// Get All Stake Accounts
Console.WriteLine("Get All Stake Accounts");
var stakeAccounts = accountClient.GetAllAccounts().Result;
foreach (var sa in stakeAccounts.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sa));
}
Console.WriteLine();

// Get Stake Information
Console.WriteLine("Get Account Information");
var stakeAddressesToRequest = new[] { "stake1u8yxtugdv63wxafy9d00nuz6hjyyp4qnggvc9a3vxh8yl0ckml2uz" };
var accountBulkRequest = new AccountBulkRequest { StakeAddresses = stakeAddressesToRequest };
var stakeInformation = accountClient.GetAccountInformation(accountBulkRequest).Result;
foreach (var si in stakeInformation.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(si));
}
Console.WriteLine();

// Get Stake Rewards
Console.WriteLine("Get Account Rewards");
var accountHistoryRequest = new AccountHistoricalBulkRequest { StakeAddresses = stakeAddressesToRequest, EpochNo = 280 };
var stakeRewards = accountClient.GetAccountRewards(accountHistoryRequest).Result;
foreach (var sr in stakeRewards.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sr));
}
Console.WriteLine();

// Get Stake Updates
Console.WriteLine("Get Account Updates");
var stakeUpdates = accountClient.GetAccountUpdates(accountBulkRequest).Result;
foreach (var su in stakeUpdates.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(su));
}
Console.WriteLine();

// Get Stake Addresses
Console.WriteLine("Get Account Stake Addresses");
var stakeAddresses = accountClient.GetAccountAddresses(accountBulkRequest).Result;
foreach (var sa in stakeAddresses.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sa));
}
Console.WriteLine();

// Get Stake Assets
Console.WriteLine("Get Account Assets");
var stakeAssets = accountClient.GetAccountAssets(accountBulkRequest).Result;
foreach (var sa in stakeAssets.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sa));
}
Console.WriteLine();

// Get Stake History
Console.WriteLine("Get Account History");
var stakeHistory = accountClient.GetAccountHistory(accountHistoryRequest).Result;
foreach (var sh in stakeHistory.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sh));
}
Console.WriteLine();

// Get Assets
Console.WriteLine("Get Assets");
var assets = assetClient.GetAssetsList().Result;
foreach (var ai in assets.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(ai));
}
Console.WriteLine();

// Get Asset Address List
Console.WriteLine("Get Asset Address List");
var policyId = "d3501d9531fcc25e3ca4b6429318c2cc374dbdbcf5e99c1c1e5da1ff";
var assetName = "444f4e545350414d";
var assetAddresses = assetClient.GetAddresses(policyId, assetName).Result;
foreach (var aa in assetAddresses.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(aa));
}
Console.WriteLine();

// Get Asset Information
Console.WriteLine("Get Asset Information");
var assetInformations = assetClient.GetInfo(policyId, assetName).Result;
foreach (var ai in assetInformations.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(ai));
}
Console.WriteLine();

// Get Asset History
Console.WriteLine("Get Asset History");
var assetHistory = assetClient.GetHistory(policyId, assetName).Result;
foreach (var history in assetHistory.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(history));
}
Console.WriteLine();

// Get Asset Policy Information
Console.WriteLine("Get Asset Policy Info");
var assetPolicyInfo = assetClient.GetPolicyInfo(policyId).Result;
foreach (var policyInfo in assetHistory.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(policyInfo));
}
Console.WriteLine();

// Get Asset Summary
Console.WriteLine("Get Asset Summary");
var assetSummary = assetClient.GetSummary(policyId, assetName).Result;
foreach (var summary in assetSummary.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(summary));
}
Console.WriteLine();

// Get Asset Transactions
Console.WriteLine("Get Asset Transactions");
var assetTransactions = assetClient.GetTransactions(policyId, assetName).Result;
foreach (var at in assetTransactions.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(at));
}
Console.WriteLine();

// Get Pool List
Console.WriteLine("Get Pool List");
var poolList = poolClient.GetList().Result;
foreach (var pl in poolList.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pl));
}
Console.WriteLine();

//Get Pool Information
Console.WriteLine("Get Pool Information");
var poolBech32Ids = new PoolInformationRequest()
{
    PoolBech32Ids = new List<string>()
    {
        "pool100wj94uzf54vup2hdzk0afng4dhjaqggt7j434mtgm8v2gfvfgp",
        "pool102s2nqtea2hf5q0s4amj0evysmfnhrn4apyyhd4azcmsclzm96m",
        "pool102vsulhfx8ua2j9fwl2u7gv57fhhutc3tp6juzaefgrn7ae35wm"
    }
};
var poolInformations = poolClient.GetInformation(poolBech32Ids).Result;
foreach (var pi in poolInformations.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pi));
}
Console.WriteLine();

// Get Pool Stake Snapshot
Console.WriteLine("Get Pool Stake Snapshot");
var poolBech32 = "pool155efqn9xpcf73pphkk88cmlkdwx4ulkg606tne970qswczg3asc";
var poolSnapshot = poolClient.GetStakeSnapshot(poolBech32).Result;
foreach (var pi in poolSnapshot.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pi));
}
Console.WriteLine();

// Get Pool Delegators
Console.WriteLine("Get Pool Delegators");
var epochNo = "294"; //optional
var poolDelegators = poolClient.GetDelegators(poolBech32).Result;
foreach (var pd in poolDelegators.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pd));
}
Console.WriteLine();

// Get Pool Delegators History
Console.WriteLine("Get Pool Delegators History");
var poolDelegatorsHistory = poolClient.GetDelegatorsHistory(poolBech32, epochNo).Result;
foreach (var pd in poolDelegatorsHistory.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pd));
}
Console.WriteLine();

// Get Pool Blocks
Console.WriteLine("Get Pool Blocks");
var poolBlocks = poolClient.GetBlocks(poolBech32, epochNo).Result;
foreach (var pb in poolBlocks.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pb));
}
Console.WriteLine();

// Get Pool History
Console.WriteLine("Get Pool History");
var poolHistory = poolClient.GetHistory(poolBech32, epochNo).Result;
foreach (var pd in poolHistory.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pd));
}
Console.WriteLine();

// Get Pool Updates
Console.WriteLine("Get Pool Updates");
var poolUpdates = poolClient.GetUpdates(poolBech32).Result;
foreach (var pu in poolUpdates.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pu));
}
Console.WriteLine();

// Get Pool Relays
Console.WriteLine("Get Pool Relays");
var poolRelays = poolClient.GetRelays().Result;
foreach (var pr in poolRelays.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pr));
}
Console.WriteLine();

// Get Pool Metadata
Console.WriteLine("Get Pool Metadata");
var poolMetadata = poolClient.GetMetadata().Result;
foreach (var pm in poolMetadata.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(pm));
}
Console.WriteLine();

// Get Native Script List
Console.WriteLine("Get Native Script List");
var scriptNativeList = scriptClient.GetNativeList().Result;
foreach (var sl in scriptNativeList.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sl));
}
Console.WriteLine();

// Get Plutus Script List
Console.WriteLine("Get Plutus Script List");
var scriptPlutusList = scriptClient.GetPlutusList().Result;
foreach (var sl in scriptPlutusList.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sl));
}
Console.WriteLine();

// Get Script Redeemers
Console.WriteLine("Get Script Redeemers");
var scriptHash = "d8480dc869b94b80e81ec91b0abe307279311fe0e7001a9488f61ff8";
var scriptRedeemers = scriptClient.GetRedeemers(scriptHash).Result;
foreach (var sr in scriptRedeemers.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(sr));
}
Console.WriteLine();

// Get Datum Information
Console.WriteLine("Get Datum Information");
var datumHashes = new[]{"818ee3db3bbbd04f9f2ce21778cac3ac605802a4fcb00c8b3a58ee2dafc17d46", "45b0cfc220ceec5b7c1c62c4d4193d38e4eba48e8815729ce75f9c0ab0e4c1c0"};
var datumInfo = scriptClient.GetDatumInformation(new GetDatumInformationRequest { DatumHashes = datumHashes}).Result;
foreach (var di in datumInfo.Content)
{
    Console.WriteLine(JsonSerializer.Serialize(di));
}
Console.WriteLine();