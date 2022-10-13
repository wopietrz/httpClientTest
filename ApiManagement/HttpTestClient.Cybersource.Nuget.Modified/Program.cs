using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientTest.Cybersource.NuGet.Modified
{
    internal class Program
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
            var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
            //TODO: Uncomment the code below to use Api Management
            //var apiInstance = new KeyGenerationApi(GetConfiguration());

            var apiInstance = new KeyGenerationApi(new Configuration(merchConfigDictObj: GetMerchantConfiguration()));
            var response = await apiInstance.GeneratePublicKeyAsync("JWT", request).ConfigureAwait(false);

            Console.WriteLine(response.KeyId);
        }

        private static async Task BenchmarkSequenceAsync()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 100; i++)
            {
                var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
                //TODO: Uncomment the code below to use Api Management
                //var apiInstance = new KeyGenerationApi(GetConfiguration());

                var apiInstance = new KeyGenerationApi(new Configuration(merchConfigDictObj: GetMerchantConfiguration()));
                var response = await apiInstance.GeneratePublicKeyAsync("JWT", request).ConfigureAwait(false);

                Console.WriteLine(i);
            }
            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Cybersource.NuGet/ Sequence Elapsed = {stopWatch.ElapsedMilliseconds}");
        }

        private static async Task BenchmarkParallelAsync()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            IEnumerable<Task> tasks = Enumerable.Range(1, 100).Select(i => Task.Run(async () =>
            {
                var delay = new Random().Next(1000, 5000);
                await Task.Delay(delay);

                var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");

                //TODO: Uncomment the code below to use Api Management
                //var apiInstance = new KeyGenerationApi(GetConfiguration());

                var apiInstance = new KeyGenerationApi(new Configuration(merchConfigDictObj: GetMerchantConfiguration()));
                var response = await apiInstance.GeneratePublicKeyAsync("JWT", request).ConfigureAwait(false);

                Console.WriteLine(i);
            }));
            await Task.WhenAll(tasks);
            stopWatch.Stop();
            Console.WriteLine($"HttpClientTest.Cybersource.NuGet/ Parallel Elapsed = {stopWatch.ElapsedMilliseconds}");
        }

        private static Configuration GetConfiguration()
        {
            var apiClient = new ApiClient("https://api-m-cybersource-test.azure-api.net/fuse");
            
            var defaultHeader = new Dictionary<string, string>();

            defaultHeader.Add("Ocp-Apim-Subscription-Key", "e895703d8c6e4ff6aea58174c024f57e");
            defaultHeader.Add("Ocp-Apim-Trace", "true");
            defaultHeader.Add("Host", "api-m-cybersource-test.azure-api.net");
            
            return new Configuration(
                apiClient, 
                merchConfigDictObj: GetMerchantConfiguration(),
                defaultHeader: defaultHeader);
        }

        private static Dictionary<string, string> GetMerchantConfiguration()
        {
            var configurationDictionary = new Dictionary<string, string>();
            configurationDictionary.Add("authenticationType", "HTTP_SIGNATURE");
            configurationDictionary.Add("merchantID", "axa_retail_ecom_sit");
            configurationDictionary.Add("merchantsecretKey", "5XVH1QXcPG2pTgpr+ruZHYcEQ8SvawJ8tI9Pophz2TI=");
            configurationDictionary.Add("merchantKeyId", "3ea190d9-be22-46e6-b2e4-fc3cd8250ce4");
            configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
            configurationDictionary.Add("keyFilename", "testrest");
            configurationDictionary.Add("keyAlias", "testrest");
            configurationDictionary.Add("keyPass", "testrest");
            configurationDictionary.Add("enableLog", "TRUE");
            configurationDictionary.Add("logDirectory", "logs");
            configurationDictionary.Add("logFileName", "application.log");
            configurationDictionary.Add("logFileMaxSize", "5242880");
            configurationDictionary.Add("timeout", "1000");

            return configurationDictionary;
        }
    }
}
