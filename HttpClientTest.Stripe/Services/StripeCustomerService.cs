namespace HttpClientTest.Stripe.Services
{
    using global::Stripe;

    internal class StripeCustomerService : ICustomerService
    {
        private readonly IStripeClient stripeClient;

        public StripeCustomerService(IStripeClient stripeClient)
        {
            this.stripeClient = stripeClient;
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
