namespace HttpClientTest.Stripe.Services
{
    using global::Stripe;
    using System.Net.Http;
    using System.Threading.Tasks;

    internal class StripeCustomerService : ICustomerService
    {
        const string apiKey = "sk_test_51J6CwAC8DfhOXr8SxF9MqPEOFlmxlDOm3EFQEhv2FG3SMTPmZw1LW3GSsxQqb6dYcxPgrz3QVzqgfPVmQk08cfli00NvfDM3xk";

        private readonly IStripeClient stripeClient;
        private readonly CustomerService service;

        public StripeCustomerService(HttpClient httpClient)
        {
            this.stripeClient = new StripeClient(
                apiKey,
                apiBase: "https://api-m-cybersource-test.azure-api.net/stripe",
                httpClient: new SystemNetHttpClient(httpClient));
            service = new CustomerService(this.stripeClient);
        }

        public async Task<string> ListCustomersAsync(int limit = 10)
        {
            var options = new CustomerListOptions
            {
                Limit = 2,
            };

            var customers = await service.ListAsync(options);
            
            return customers.ToJson();
        }

        public string ListCustomers(int limit = 10)
        {
            return this.ListCustomersAsync(limit).Result;
        }
    }
}