namespace HttpClientTest.AdyenClient
{
    using HttpClientTest.AdyenClient.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await SingleCall();
            await BenchmarkSequenceAsync();
            //await BenchmarkParallelAsync();

            Console.ReadKey();
        }

        private static async Task SingleCall()
        {
            var serviceProvider = Startup.ConfigureServices();

            var service = serviceProvider.GetService<IAdyenService>();
            var result = await service.Pay();


            Console.WriteLine(result);
        }

        private static async Task BenchmarkSequenceAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var service = serviceProvider.GetService<IAdyenService>();
            for (int i = 0; i < 100; i++)
            {
                var result = await service.Pay();
                Console.WriteLine(i);
            }

            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Adyen/ Sequence Elapsed = {stopWatch.ElapsedMilliseconds}");
        }

        private static async Task BenchmarkParallelAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var service = serviceProvider.GetService<IAdyenService>();
            IEnumerable<Task> tasks = Enumerable.Range(1, 100).Select(i => Task.Run(async () =>
            {
                var delay = new Random().Next(1000, 5000);
                await Task.Delay(delay);

                var result = await service.Pay();

                Console.WriteLine(i);
            }));
            await Task.WhenAll(tasks);
            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Adyen/ Parralel Elapsed = {stopWatch.ElapsedMilliseconds}");
        }
    }
}
