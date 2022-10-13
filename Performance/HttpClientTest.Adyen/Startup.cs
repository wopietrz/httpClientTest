namespace HttpClientTest.AdyenClient
{
    using HttpClientTest.AdyenClient.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public static class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<IAdyenService, AdyenService>();
            
                return services.BuildServiceProvider();
        }
    }
}
