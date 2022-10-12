namespace HttpClientTest.AdyenClient
{
    using HttpClientTest.AdyenClient.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    internal class Program
    {
        static async Task Main(string[] args)
        {
            //SingleCall();
            await BenchmarkAsync();
        }

        private static async Task SingleCall()
        {
            var serviceProvider = Startup.ConfigureServices();

            var service = serviceProvider.GetService<IAdyenService>();
            var result = await service.Pay();


            Console.WriteLine(result);
        }

        private static async Task BenchmarkAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 100; i++)
            {
                var service = serviceProvider.GetService<IAdyenService>();
                var result = await service.Pay();
                Console.WriteLine(i);
            }

            stopWatch.Stop();
            Console.WriteLine($"Elapsed = {stopWatch.ElapsedMilliseconds}");
        }
    }
}
