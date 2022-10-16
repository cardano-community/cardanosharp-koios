using System;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace CardanoSharp.Koios.Client
{
    public static class KoiosExtensions
    {
        public static void AddKoios(
            this IServiceCollection services,
            string endpoint)
        {
            var uri = new Uri(endpoint);

            services.AddRefitClient<INetworkClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<IEpochClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<IBlockClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<ITransactionClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<IAddressClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<IAccountClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<IAssetClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<IPoolClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
            services.AddRefitClient<IScriptClient>()
                .ConfigureHttpClient(c => c.BaseAddress = uri);
        }
    }
}