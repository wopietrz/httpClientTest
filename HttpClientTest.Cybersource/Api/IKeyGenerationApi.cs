namespace HttpClientTest.Cybersource.Api
{
    using HttpClientTest.Cybersource.Model;
    using System.Threading.Tasks;

    public interface IKeyGenerationApi
    {
        Task<string> GeneratePublicKeyAsync(string format, GeneratePublicKeyRequest request);
    }
}
