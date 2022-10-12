using HttpClientTest.Cybersource.Prototype.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HttpClientTest.Cybersource.Prototype
{
    internal class Program
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

            var service = serviceProvider.GetService<ICybersourceService>();
            var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
            var result = await service.GeneratePublicKeyAsync("JWT", request);

            Console.WriteLine(result);
        }

        private static async Task BenchmarkAsync()
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
            Console.WriteLine($"HttpClientTest.Cybersource.Prototype Elapsed = {stopWatch.ElapsedMilliseconds}");
        }
    }
}
