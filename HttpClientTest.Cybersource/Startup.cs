namespace HttpClientTest.Cybersource
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public sealed class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddHttpClient<ICybersourceService, CybersourceService>(
                httpClient =>
                {
                    httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "e895703d8c6e4ff6aea58174c024f57e");
                    httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Trace", "true");
                    httpClient.DefaultRequestHeaders.Add("Host", "api-m-cybersource-test.azure-api.net");
                    return new CybersourceService(httpClient);
                });

            return services.BuildServiceProvider();
        }
    }
}
