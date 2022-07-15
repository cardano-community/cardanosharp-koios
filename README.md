# CardanoSharp Koios SDK 
 [![NuGet Version](https://img.shields.io/nuget/v/CardanoSharp.Koios.Sdk.svg?style=flat)](https://www.nuget.org/packages/CardanoSharp.Koios.Sdk/) ![NuGet Downloads](https://img.shields.io/nuget/dt/CardanoSharp.Koios.Sdk.svg)

This library helps .NET developers leverage the Koios Api

This library is still a work in progress...

## Koios
Koios is best described as a Decentralized and Elastic RESTful query layer for exploring data on Cardano blockchain to consume within applications/wallets/explorers/etc.

Learn more here: [https://api.koios.rest/](https://api.koios.rest/)

## Getting Started

Add Nuget
```bash
dotnet add package CardanoSharp.Koios.Sdk
```

## Network

Get instance of the `INetworkClient`

```cs
// Simple Resolution
INetworkClient networkClient = RestService.For<INetworkClient>("https://api.koios.rest/api/v0");
```

### Get Query Chain Tip

```cs
BlockSummary[] chainTip = networkClient.GetChainTip().Result;
```

### Get Genesis Info

```cs
GenesisParameters[] genesisInfo = networkClient.GetGenesisInfo().Result;
```

### Get Historical Tokenomic Stats

```cs
string latestEpoch = "294";
TokenomicStats[] historicalStats = networkClient.GetHistoricalTokenomicStats(latestEpoch).Result;
```

## Epoch

Get instance of the `IEpochClient`

```cs
// Simple Resolution
IEpochClient epochClient = RestService.For<IEpochClient>("https://api.koios.rest/api/v0");
```

### Get Epoch Information

```cs
EpochInformation[] epochInformations = epochClient.GetEpochInformation().Result;
```

### Get Protocol Parameters

```cs
string latestEpoch = "294";
ProtocolParameters[] protocolParameters = epochClient.GetProtocolParameters(latestEpoch).Result;
```

## Block

Get instance of the `IBlockClient`

```cs
// Simple Resolution
IBlockClient blockClient = RestService.For<IBlockClient>("https://api.koios.rest/api/v0");
```

### Get Block List

```cs
Block[] blockList = blockClient.GetBlockList().Result;
```

### Get Block Information

```cs
string blockHash = "f6192a1aaa6d3d05b4703891a6b66cd757801c61ace86cbe5ab0d66e07f601ab";
Block[] blockInfo = blockClient.GetBlockInfo(blockHash).Result;
```

### Get Block Transactions

```cs
string blockHash = "f6192a1aaa6d3d05b4703891a6b66cd757801c61ace86cbe5ab0d66e07f601ab";
BlockTransaction[] blockTransactions = blockClient.GetBlockTransactions(blockHash).Result;
```


## Transaction

Get instance of the `ITransactionClient`

```cs
// Simple Resolution
ITransactionClient transactionClient = RestService.For<ITransactionClient>("https://api.koios.rest/api/v0");
```
### Get Transaction Information

```cs
var transactionRequest = new GetTransactionRequest
{
    TxHashes = new List<string>()
    {
        "f144a8264acf4bdfe2e1241170969c930d64ab6b0996a4a45237b623f1dd670e",
        "0b8ba3bed976fa4913f19adc9f6dd9063138db5b4dd29cecde369456b5155e94"
    }
};
Transaction[] transactionInformation = transactionClient.GetTransactionInformation(transactionRequest).Result;
```
### Get Transaction UTxOs

```cs
var transactionRequest = new GetTransactionRequest
{
    TxHashes = new List<string>()
    {
        "f144a8264acf4bdfe2e1241170969c930d64ab6b0996a4a45237b623f1dd670e",
        "0b8ba3bed976fa4913f19adc9f6dd9063138db5b4dd29cecde369456b5155e94"
    }
};
Transaction[] transactionUtxos = transactionClient.GetTransactionUtxos(transactionRequest).Result;
```
### Get Transaction Metadata

```cs
var transactionRequest = new GetTransactionRequest
{
    TxHashes = new List<string>()
    {
        "f144a8264acf4bdfe2e1241170969c930d64ab6b0996a4a45237b623f1dd670e",
        "0b8ba3bed976fa4913f19adc9f6dd9063138db5b4dd29cecde369456b5155e94"
    }
};
TransactionMetadata[] transactionMetadata = transactionClient.GetTransactionMetadata(transactionRequest).Result;
```
### Get Transaction Status

```cs
var transactionRequest = new GetTransactionRequest
{
    TxHashes = new List<string>()
    {
        "f144a8264acf4bdfe2e1241170969c930d64ab6b0996a4a45237b623f1dd670e",
        "0b8ba3bed976fa4913f19adc9f6dd9063138db5b4dd29cecde369456b5155e94"
    }
};
TransactionStatus[] transactionStatus = transactionClient.GetTransactionStatus(transactionRequest).Result;
```

### Submit Transaction

```cs
string signedTxStr = "83a6008182582084c204d1a649fa8fe0a7d50989465baf71d2a371a886d1344395b8316bd3abfb00018282583900550c1b4b5deeea285479bbbc331d78220dc813b3636808186fad1b2154a7f74869944ecbe91d8e8de2642c172c620520cda6d3d29cdbfa48821a001e8480a1581c4d3b2796fd8b9b2242699b1dd1c6aa5e079bd2ceb084aeba664cbfeda14d53686172704e6f7465626f6f6b0182583900ff13307529d67cc23a1bde15c67c2f1410ecfcbb1b03fbe11cd26920e0094f2b527fd1c46d28f707b01a5566876137a4fd62cc0740fb6c4e1a0076d6b3021a00033b4d031a035ec095075820b9cd4185d6dec9954c6534c63aac48dfa540de027c647e7d5a1e39b661d091c809a1581c4d3b2796fd8b9b2242699b1dd1c6aa5e079bd2ceb084aeba664cbfeda14d53686172704e6f7465626f6f6b01a20082825820ec96948e3dc78e245ba9fd57c91dc4099c36be848e3d9a593b202ef01d2c47e65840ea0f581b8d712fad1b0c5723048d27b5f4e49fc63e4c9c55545a4156c1f754ad34b74195adb8d89cbaef0bc11d7123a5e3cbcb2f91a412f8b073cba13a86c70482582095a193e076285356c3a8294f4e6c22e5d2023af48ca672ba7e18af4788ccd563584036acf806251117254b945b6b6ca40d18074e923158f4fc18ac8bad8ef861277c3785cb06d82cda613d3d8ca9d152bafbdd36293ad783471108ea31aae9e7a90a01818201818200581c39cb1fd8aa0778a0ac171eaf6e4e4f945516efa429a77611c3fa7f1e82a1190539a2657469746c65782043617264616e6f5368617270204b6f696f73205478205375626d697373696f6e676d657373616765781f43617264616e6f5368617270202b204b6f696f73203d20537563636573732180";
byte[] signedTx = signedTxStr.HexToByteArray();

var txId = string.Empty;
using (MemoryStream stream = new MemoryStream(signedTx))
    txId = await transactionClient.Submit(stream);
```

## Address

Get instance of the `IAddressClient`

```cs
// Simple Resolution
IAddressClient addressClient = RestService.For<IAddressClient>("https://api.koios.rest/api/v0");
```
### Get Address Information

```cs
var address = "addr1qyp9kz50sh9c53hpmk3l4ewj9ur794t2hdqpngsjn3wkc5sztv9glpwt3frwrhdrltjaytc8ut2k4w6qrx3p98zad3fq07xe9g";
AddressInformation[] addressInformation = addressClient.GetAddressInformation(address).Result;
```
### Get Address Transactions

```cs
var addressTransactionRequest = new AddressTransactionRequest()
{
    Addresses = new List<string>()
    {
        "addr1qyp9kz50sh9c53hpmk3l4ewj9ur794t2hdqpngsjn3wkc5sztv9glpwt3frwrhdrltjaytc8ut2k4w6qrx3p98zad3fq07xe9g",
        "addr1qyfldpcvte8nkfpyv0jdc8e026cz5qedx7tajvupdu2724tlj8sypsq6p90hl40ya97xamkm9fwsppus2ru8zf6j8g9sm578cu"
    },
    AfterBlockHeight = 6238675
};
AddressTransaction[] addressTransactions = addressClient.GetAddressTransactions(addressTransactionRequest).Result;
```
### Get Address Assets

```cs
var address = "addr1q8h22z0n3zqecr9n4q9ysds2m2ms3dqesz575accjpc3jclw55yl8zypnsxt82q2fqmq4k4hpz6pnq9fafm33yr3r93sgnpdw6";
AddressAssets[] addressAssets = addressClient
.GetAddressAssets(address).Result;
```
### Get Transactions from Payment Credentials

```cs
var credentialTransactionRequest = new CredentialTransactionRequest()
{
    PaymentCredentials = new List<string>()
    {
        "025b0a8f85cb8a46e1dda3fae5d22f07e2d56abb4019a2129c5d6c52",
        "13f6870c5e4f3b242463e4dc1f2f56b02a032d3797d933816f15e555"
    },
    AfterBlockHeight = 6238675
};
AddressTransaction[] credentialTransactions = addressClient
.GetCredentialTransactions(credentialTransactionRequest).Result;
```

## Account

Get instance of the `IAccountClient`

```cs
// Simple Resolution
IAccountClient accountClient = RestService.For<IAccountClient>("https://api.koios.rest/api/v0");
```

### Get All Stake Accounts

```cs
StakeAccount[] stakeAccounts = accountClient.GetAllStakeAccounts().Result;
```

### Get Stake Information

```cs
var stakeAddress = "stake1u8yxtugdv63wxafy9d00nuz6hjyyp4qnggvc9a3vxh8yl0ckml2uz";
StakeInformation[] stakeInformation = accountClient.GetStakeInformation(stakeAddress).Result;
```

### Get Stake Rewards

```cs
var stakeAddress = "stake1u8yxtugdv63wxafy9d00nuz6hjyyp4qnggvc9a3vxh8yl0ckml2uz";
StakeReward[] stakeRewards = accountClient.GetStakeRewards(stakeAddress).Result;
```

### Get Stake Updates

```cs
var stakeAddress = "stake1u8yxtugdv63wxafy9d00nuz6hjyyp4qnggvc9a3vxh8yl0ckml2uz";
StakeUpdate[] stakeUpdates = accountClient.GetStakeUpdates(stakeAddress).Result;
```

### Get Stake Addresses

```cs
var stakeAddress = "stake1u8yxtugdv63wxafy9d00nuz6hjyyp4qnggvc9a3vxh8yl0ckml2uz";
StakeAddress[] stakeAddresses = accountClient.GetStakeAddresses(stakeAddress).Result;
```

### Get Stake Assets

```cs
var stakeAddress = "stake1u8yxtugdv63wxafy9d00nuz6hjyyp4qnggvc9a3vxh8yl0ckml2uz";
StakeAsset[] stakeAssets = accountClient.GetStakeAssets(stakeAddress).Result;
```

### Get Stake History

```cs
var stakeAddress = "stake1u8yxtugdv63wxafy9d00nuz6hjyyp4qnggvc9a3vxh8yl0ckml2uz";
StakeHistory[] stakeHistory = accountClient.GetStakeHistory(stakeAddress).Result;
```

## Assets

Get instance of the `IAssetClient`

```cs
// Simple Resolution
IAssetClient assetClient = RestService.For<IAssetClient>("https://api.koios.rest/api/v0");
```

### Get Assets List

```cs
Asset[] assets = assetClient.GetAssetsList().Result;
```

### Get Asset Address List

```cs
var policyId = "d3501d9531fcc25e3ca4b6429318c2cc374dbdbcf5e99c1c1e5da1ff";
var assetName = "444f4e545350414d";
AssetAddress[] assetAddresses = assetClient.GetAddresses(policyId, assetName).Result;
```

### Get Asset Information

```cs
var policyId = "d3501d9531fcc25e3ca4b6429318c2cc374dbdbcf5e99c1c1e5da1ff";
var assetName = "444f4e545350414d";
AssetInformation[] assetInformations = assetClient.GetInfo(policyId, assetName).Result;
```

### Get Asset Transactions

```cs
var policyId = "d3501d9531fcc25e3ca4b6429318c2cc374dbdbcf5e99c1c1e5da1ff";
var assetName = "444f4e545350414d";
AssetTransaction[] assetTransactions = assetClient.GetTransactions(policyId, assetName).Result;
```

## Pool

Get instance of the `IPoolClient`

```cs
// Simple Resolution
IPoolClient poolClient = RestService.For<IPoolClient>("https://api.koios.rest/api/v0");
```

### Get Pool List

```cs
PoolList[] poolList = poolClient.GetList().Result;
```

### Get Pool Information

```cs
var poolBech32 = "pool155efqn9xpcf73pphkk88cmlkdwx4ulkg606tne970qswczg3asc";
PoolInformation[] poolInformations = poolClient.GetInformation(poolBech32).Result;
```

### Get Pool Delegators

```cs
var poolBech32 = "pool155efqn9xpcf73pphkk88cmlkdwx4ulkg606tne970qswczg3asc";
var epochNo = "294"; //optional
PoolDelegator[] poolDelegators = poolClient.GetDelegators(poolBech32, epochNo).Result;
```

### Get Pool Blocks

```cs
var poolBech32 = "pool155efqn9xpcf73pphkk88cmlkdwx4ulkg606tne970qswczg3asc";
var epochNo = "294"; //optional
PoolBlock[] poolBlocks = poolClient.GetBlocks(poolBech32, epochNo).Result;
```

### Get Pool Updates

```cs
var poolBech32 = "pool155efqn9xpcf73pphkk88cmlkdwx4ulkg606tne970qswczg3asc";
PoolUpdate[] poolUpdates = poolClient.GetUpdates(poolBech32).Result;
```

### Get Pool Relays

```cs
PoolRelay[] poolRelays = poolClient.GetRelays().Result;
```

### Get Pool Metadata

```cs
PoolMetadata[] poolMetadata = poolClient.GetMetadata().Result;
```

## Script

Get instance of the `IScriptClient`

```cs
// Simple Resolution
IScriptClient scriptClient = RestService.For<IScriptClient>("https://api.koios.rest/api/v0");
```

### Get Native Script List

```cs
ScriptList[] scriptList = scriptClient.GetNativeList().Result;
```

### Get Plutus Script List

```cs
ScriptList[] scriptList = scriptClient.GetPlutusList().Result;
```

### Get Script Redeemers

```cs
var scriptHash = "d8480dc869b94b80e81ec91b0abe307279311fe0e7001a9488f61ff8";
ScriptRedeemer[] scriptRedeemers = scriptClient.GetRedeemers(scriptHash).Result;
```