﻿using CyberSource.Api;
using CyberSource.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HttpClientTest.Cybersource.NuGet
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
            var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
            var apiInstance = new KeyGenerationApi(new CyberSource.Client.Configuration(merchConfigDictObj: GetConfiguration()));
            var response = await apiInstance.GeneratePublicKeyAsync("JWT", request).ConfigureAwait(false);

            Console.WriteLine(response.KeyId);
        }

        private static async Task BenchmarkAsync()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 100; i++)
            {
                var request = new GeneratePublicKeyRequest("RsaOaep256", "https://www.test.com");
                var apiInstance = new KeyGenerationApi(new CyberSource.Client.Configuration(merchConfigDictObj: GetConfiguration()));
                var response = await apiInstance.GeneratePublicKeyAsync("JWT", request).ConfigureAwait(false);

                Console.WriteLine(i);
            }
            stopWatch.Stop();
            Console.WriteLine($"Elapsed = {stopWatch.ElapsedMilliseconds}");
        }

        private static Dictionary<string, string> GetConfiguration()
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