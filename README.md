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
### Get Address Information

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
### Get Address Information

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