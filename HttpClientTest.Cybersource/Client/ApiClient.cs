namespace HttpClientTest.Cybersource.Prototype.Client
{
    using AuthenticationSdk.core;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public class ApiClient
    {
        private readonly RestClient restClient;
        private readonly Configuration configuration;
        
        public ApiClient(HttpClient httpClient, Configuration configuration)
        {
            this.configuration = configuration;
            this.restClient = new RestClient(httpClient, new RestClientOptions() { BaseUrl = new Uri(configuration.BasePath) });
        }

        public async Task<string> CallApiAsync(string resource, Method httpMethod, Dictionary<string, string> queryParameters, string requestBody)
        {
            var restRequest = new RestRequest()
            {
                Method = httpMethod,
                Resource = resource
            };

            restRequest.AddStringBody(requestBody, DataFormat.Json);

            string path = resource;

            var firstQueryParam = true;
            foreach (var parameter in queryParameters)
            {
                restRequest.AddQueryParameter(parameter.Key, parameter.Value);

                var key = parameter.Key;
                var val = parameter.Value;

                if (!firstQueryParam)
                {
                    path = path + "&" + key + "=" + val;
                }
                else
                {
                    path = path + "?" + key + "=" + val;
                    firstQueryParam = false;
                }
            }


            var authenticationHeaders = this.CallAuthenticationHeaders("Post", path, requestBody);
            restRequest.AddOrUpdateHeaders(authenticationHeaders);
            restRequest.AddHeader("Content-Type", "application/json");

            var response = await this.restClient.ExecuteAsync(restRequest);

            return response.Content;
        }

        public string CallApi(string resource, Method httpMethod, Dictionary<string, string> queryParameters, string requestBody)
        {
            return this.CallApiAsync(resource, httpMethod, queryParameters, requestBody).Result;
        }

        private IDictionary<string, string> CallAuthenticationHeaders(string requestType, string requestTarget, string requestJsonData = null)
        {
            requestTarget = Uri.EscapeUriString(requestTarget);

            var merchantConfig = this.configuration.MerchantConfigDictionaryObj != null
                    ? new MerchantConfig(this.configuration.MerchantConfigDictionaryObj)
                    : new MerchantConfig();

            merchantConfig.RequestType = requestType;
            merchantConfig.RequestTarget = requestTarget;
            merchantConfig.RequestJsonData = requestJsonData;

            var authenticationHeaders = new Dictionary<string, string>();

            var authorize = new Authorize(merchantConfig);

            //generate signature and set HTTP Signature headers
            var httpSign = authorize.GetSignature();
            authenticationHeaders.Add("v-c-merchant-id", httpSign.MerchantId);
            authenticationHeaders.Add("Date", httpSign.GmtDateTime);
            authenticationHeaders.Add("Host", this.restClient.Options.BaseUrl.Host);
            authenticationHeaders.Add("Signature", httpSign.SignatureParam);

            if (merchantConfig.IsPostRequest || merchantConfig.IsPutRequest || merchantConfig.IsPatchRequest)
                authenticationHeaders.Add("Digest", httpSign.Digest);

            return authenticationHeaders;
        }
    }
}
