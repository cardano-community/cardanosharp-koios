FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CardanoSharp.Koios.Sample/CardanoSharp.Koios.Sample.csproj", "CardanoSharp.Koios.Sample/"]
RUN dotnet restore "CardanoSharp.Koios.Sample/CardanoSharp.Koios.Sample.csproj"
COPY . .
WORKDIR "/src/CardanoSharp.Koios.Sample"
RUN dotnet build "CardanoSharp.Koios.Sample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CardanoSharp.Koios.Sample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CardanoSharp.Koios.Sample.dll"]
