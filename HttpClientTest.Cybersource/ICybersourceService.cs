namespace HttpClientTest.Cybersource.Prototype
{
    using HttpClientTest.Cybersource.Prototype.Model;
    using System.Threading.Tasks;

    public interface ICybersourceService
    {
        Task<string> GeneratePublicKeyAsync(string format, GeneratePublicKeyRequest request);

        string GetneratePublicKey(string format, GeneratePublicKeyRequest request);
    }
}
