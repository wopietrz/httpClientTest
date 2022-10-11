namespace HttpClientTest.Stripe.Services
{
    using System.Threading.Tasks;

    public interface ICustomerService
    {
        Task<string> ListCustomersAsync(int limit = 10);

        string ListCustomers(int limit = 10);
    }
}
