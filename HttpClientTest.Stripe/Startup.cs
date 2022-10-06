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

            services.AddHttpClient<ICustomerService, StripeCustomerService>(httpClient => new StripeCustomerService(httpClient));
                
            return services.BuildServiceProvider();
        }
    }
}
