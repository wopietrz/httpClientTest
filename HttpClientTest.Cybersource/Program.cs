using HttpClientTest.Cybersource.Model;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HttpClientTest.Cybersource
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = Startup.ConfigureServices();

            var service = serviceProvider.GetService<ICybersourceService>();

            var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");

            var result = service.GetneratePublicKey("JWT", request);

            Console.WriteLine(result);
        }
    }
}
