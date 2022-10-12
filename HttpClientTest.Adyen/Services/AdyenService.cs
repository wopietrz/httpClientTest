﻿namespace HttpClientTest.AdyenClient.Services
{
    using Adyen;
    using Adyen.Model.Checkout;
    using Adyen.Service;
    using Newtonsoft.Json;
    using System;
    using System.Threading.Tasks;

    public class AdyenService : IAdyenService
    {
        private const string key = "AQEkhmfuXNWTK0Qc+iSSm3EqqMyeRJt99rwUUIDfz/guyXRnELc1EMFdWw2+5HzctViMSCJMYAc=-lFuZxZRQIqrtNiwJZ9Z2nH/ENlKr1h6feT5b48rmKFU=-(xeNd]pE[tJ6AS+*";

        private readonly Client client;
        public AdyenService()
        {
            this.client = new Client(key,Adyen.Model.Enum.Environment.Test);
        }


        public async Task<string> Pay()
        {
            var checkout = new Checkout(client);
            var amount = new Amount("EUR", 1000);
            var paymentMethodsRequest = new PaymentMethodsRequest(merchantAccount: "BiuroHelpECOM")
            {
                CountryCode = "NL",
                ShopperLocale = "nl-NL",
                Amount = amount,
                Channel = PaymentMethodsRequest.ChannelEnum.Web
            };
            try
            {
                var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest);
                return JsonConvert.SerializeObject(paymentMethodsResponse);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
