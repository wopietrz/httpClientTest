﻿namespace HttpClientTest.Stripe.Services
{
    using global::Stripe;
    using System.Net.Http;

    internal class StripeCustomerService : ICustomerService
    {
        const string apiKey = "sk_test_51J6CwAC8DfhOXr8SxF9MqPEOFlmxlDOm3EFQEhv2FG3SMTPmZw1LW3GSsxQqb6dYcxPgrz3QVzqgfPVmQk08cfli00NvfDM3xk";

        private readonly IStripeClient stripeClient;

        public StripeCustomerService(HttpClient httpClient)
        {
            this.stripeClient = new StripeClient(apiKey, httpClient: new SystemNetHttpClient(httpClient));
        }

        public string ListCustomers(int limit = 10)
        {
            var service = new CustomerService(stripeClient);
            var options = new CustomerListOptions
            {
                Limit = 2,
            };

            return service.List(options).ToJson();
        }
    }
}
