using Newtonsoft.Json;

namespace HttpClientTest.Cybersource.Prototype.Model
{
    public class GeneratePublicKeyRequest
    {
        public GeneratePublicKeyRequest(string encryptionType, string targetOrigin)
        {
            this.EncryptionType = encryptionType;
            this.TargetOrigin = targetOrigin;
        }

        [JsonProperty("encryptionType")]
        public string EncryptionType { get; }

        [JsonProperty("targetOrigin")]
        public string TargetOrigin { get; }
    }
}
