namespace HttpClientTest.Stripe
{
    using HttpClientTest.Stripe.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    
    public class Program
    {
        public static void Main()
        {
            var serviceProvider = Startup.ConfigureServices();

            var customerService = serviceProvider.GetService<ICustomerService>();
            var result = customerService.ListCustomers();

            Console.WriteLine(result);
        }
    }
}
