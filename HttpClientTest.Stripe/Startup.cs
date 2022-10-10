namespace HttpClientTest.Stripe
{
    using HttpClientTest.Stripe.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Net.Http;

    public sealed class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddHttpClient<ICustomerService, StripeCustomerService>(
                httpClient =>
                {
                    httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "e895703d8c6e4ff6aea58174c024f57e");
                    httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Trace", "true");
                    return new StripeCustomerService(httpClient);
                });

            return services.BuildServiceProvider();
        }
    }
}
