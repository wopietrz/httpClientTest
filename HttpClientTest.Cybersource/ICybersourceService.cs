namespace HttpClientTest.Cybersource
{
    using HttpClientTest.Cybersource.Model;
    using System.Threading.Tasks;

    public interface ICybersourceService
    {
        Task<string> GeneratePublicKeyAsync(string format, GeneratePublicKeyRequest request);

        string GetneratePublicKey(string format, GeneratePublicKeyRequest request);
    }
}
