namespace HttpClientTest.Stripe
{
    using HttpClientTest.Stripe.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main()
        {
            //await SingleCallAsync();
            await BenchmarkAsync();
            Console.ReadKey();
        }

        private static async Task SingleCallAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            var customerService = serviceProvider.GetService<ICustomerService>();
            var result = await customerService.ListCustomersAsync();

            Console.WriteLine(result);
        }

        private static async Task BenchmarkAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 100; i++)
            {
                var customerService = serviceProvider.GetService<ICustomerService>();
                var result = await customerService.ListCustomersAsync();
                Console.WriteLine(i);
            }

            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Stripe Elapsed = {stopWatch.ElapsedMilliseconds}");
        }
    }
}
