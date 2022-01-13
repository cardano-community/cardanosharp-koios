# CardanoSharp Koios SDK 
 [![NuGet Version](https://img.shields.io/nuget/v/CardanoSharp.Koios.Sdk.svg?style=flat)](https://www.nuget.org/packages/CardanoSharp.Koios.Sdk/) ![NuGet Downloads](https://img.shields.io/nuget/dt/CardanoSharp.Koios.Sdk.svg)

This library helps .NET developers leverage the Koios Api

This library is still a work in progress...

## Koios
Koios is best described as a Decentralized and Elastic RESTful query layer for exploring data on Cardano blockchain to consume within applications/wallets/explorers/etc.

Learn more here: [https://api.koios.rest/](https://api.koios.rest/)

## Getting Started

Add nuget package: CardanoSharp.Koios.Sdk

Link: [https://www.nuget.org/packages/CardanoSharp.Koios.Sdk/](https://www.nuget.org/packages/CardanoSharp.Koios.Sdk/)

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