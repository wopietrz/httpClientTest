using HttpClientTest.Cybersource.Prototype.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientTest.Cybersource.Prototype
{
    internal class Program
    {
        public static async Task Main()
        {
            //await SingleCallAsync();
            await BenchmarkSequenceAsync();
           // await BenchmarkParallelAsync();
            Console.ReadKey();
        }

        private static async Task SingleCallAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            var service = serviceProvider.GetService<ICybersourceService>();
            var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
            var result = await service.GeneratePublicKeyAsync("JWT", request);

            Console.WriteLine(result);
        }

        private static async Task BenchmarkSequenceAsync()
        {
            var serviceProvider = Startup.ConfigureServices();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 100; i++)
            {
                var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
                var service = serviceProvider.GetService<ICybersourceService>();
                var result = await service.GeneratePublicKeyAsync("JWT", request);

                Console.WriteLine(i);
            }

            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Cybersource.Prototype/ Sequence Elapsed = {stopWatch.ElapsedMilliseconds}");
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

                var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
                var service = serviceProvider.GetService<ICybersourceService>();
                var result = await service.GeneratePublicKeyAsync("JWT", request);

                Console.WriteLine(i);
            }));
            await Task.WhenAll(tasks);
            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Cybersource.Prototype/ Parralel Elapsed = {stopWatch.ElapsedMilliseconds}");
        }
    }
}
