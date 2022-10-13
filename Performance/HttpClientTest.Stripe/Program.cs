namespace HttpClientTest.Stripe
{
    using HttpClientTest.Stripe.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main()
        {
            await SingleCallAsync();
            await BenchmarkSequenceAsync();
            await BenchmarkParallelAsync();
            Console.ReadKey();
        }

        private static async Task SingleCallAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            var customerService = serviceProvider.GetService<ICustomerService>();
            var result = await customerService.ListCustomersAsync();

            Console.WriteLine(result);
        }

        private static async Task BenchmarkSequenceAsync()
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

        private static async Task BenchmarkParallelAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            IEnumerable<Task> tasks = Enumerable.Range(1, 100).Select(i => Task.Run(async () =>
            {
                var delay = new Random().Next(1000, 5000);
                await Task.Delay(delay);

                var customerService = serviceProvider.GetService<ICustomerService>();
                var result = await customerService.ListCustomersAsync();

                Console.WriteLine(i);
            }));
            await Task.WhenAll(tasks);
            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Stripe Elapsed = {stopWatch.ElapsedMilliseconds}");
        }
    }
}
