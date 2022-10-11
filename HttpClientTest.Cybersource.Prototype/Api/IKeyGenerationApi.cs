namespace HttpClientTest.Cybersource.Prototype.Api
{
    using HttpClientTest.Cybersource.Prototype.Model;
    using System.Threading.Tasks;

    public interface IKeyGenerationApi
    {
        Task<string> GeneratePublicKeyAsync(string format, GeneratePublicKeyRequest request);
    }
}
