namespace HttpClientTest.Stripe
{
    using global::Stripe;
    using HttpClientTest.Stripe.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Net.Http;

    public sealed class Startup
    {
        const string apiKey = "sk_test_51J6CwAC8DfhOXr8SxF9MqPEOFlmxlDOm3EFQEhv2FG3SMTPmZw1LW3GSsxQqb6dYcxPgrz3QVzqgfPVmQk08cfli00NvfDM3xk";
        
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddHttpClient("Stripe");
            services.AddTransient<IStripeClient, StripeClient>(s =>
            {
                var clientFactory = s.GetRequiredService<IHttpClientFactory>();
                var httpClient = new SystemNetHttpClient(
                   httpClient: clientFactory.CreateClient("Stripe"),
                   maxNetworkRetries: StripeConfiguration.MaxNetworkRetries,
                   enableTelemetry: StripeConfiguration.EnableTelemetry);

                return new StripeClient(apiKey: apiKey, httpClient: httpClient);
            });

            services.AddSingleton<ICustomerService, StripeCustomerService>();
                
            return services.BuildServiceProvider();
        }
    }
}
