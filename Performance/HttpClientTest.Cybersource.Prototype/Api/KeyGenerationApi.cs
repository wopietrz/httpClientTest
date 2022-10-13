namespace HttpClientTest.Cybersource.Prototype.Api
{
    using HttpClientTest.Cybersource.Prototype.Client;
    using HttpClientTest.Cybersource.Prototype.Model;
    using Newtonsoft.Json;
    using RestSharp;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class KeyGenerationApi : IKeyGenerationApi
    {
        private readonly ApiClient apiClient;

        public KeyGenerationApi(HttpClient httpClient, Configuration configuration)
        {
            this.apiClient = new ApiClient(httpClient, configuration);
        }

        public async Task<string> GeneratePublicKeyAsync(string format, GeneratePublicKeyRequest request)
        {
            var requestBody = JsonConvert.SerializeObject(request);
            var queryParametes = new Dictionary<string, string>
            {
                { "format", format }
            };


            return await this.apiClient.CallApiAsync("/flex/v1/keys", Method.Post, queryParametes, requestBody);
        }
    }
}
