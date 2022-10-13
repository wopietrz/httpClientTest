namespace HttpClientTest.Cybersource.Prototype
{
    using HttpClientTest.Cybersource.Prototype.Api;
    using HttpClientTest.Cybersource.Prototype.Client;
    using HttpClientTest.Cybersource.Prototype.Model;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class CybersourceService : ICybersourceService
    {
        private readonly HttpClient httpClient;
        private readonly KeyGenerationApi api;

        public CybersourceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            var configuration = new Configuration(GetMerchantConfiguration())
            {
                BasePath = "https://api-m-cybersource-test.azure-api.net/fuse",
            };
            api = new KeyGenerationApi(httpClient, configuration);
        }

        public async Task<string> GeneratePublicKeyAsync(string format, GeneratePublicKeyRequest request)
        {
            return await api.GeneratePublicKeyAsync(format, request);
        }

        public string GetneratePublicKey(string format, GeneratePublicKeyRequest request)
        {
            return this.GeneratePublicKeyAsync(format, request).Result;
        }

        private IReadOnlyDictionary<string, string> GetMerchantConfiguration()
        {
            var configurationDictionary = new Dictionary<string, string>();
            configurationDictionary.Add("authenticationType", "HTTP_SIGNATURE");
            configurationDictionary.Add("merchantID", "<TODO>");
            configurationDictionary.Add("merchantsecretKey", "<TODO>");
            configurationDictionary.Add("merchantKeyId", "<TODO>");
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
