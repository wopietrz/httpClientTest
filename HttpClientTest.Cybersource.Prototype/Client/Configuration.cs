namespace HttpClientTest.Cybersource.Prototype.Client
{
    using System.Collections.Generic;

    public class Configuration
    {
        public Configuration (
            IReadOnlyDictionary<string, string> merchantConfigObj)
        {
            this.MerchantConfigDictionaryObj = merchantConfigObj;
        }
        public IReadOnlyDictionary<string, string> MerchantConfigDictionaryObj { get; }

        public string BasePath { get; set; }
    }
}
