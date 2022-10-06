namespace HttpClientTest.Stripe.Services
{
    public interface ICustomerService
    {
        string ListCustomers(int limit = 10);
    }
}
