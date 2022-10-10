namespace HttpClientTest.Cybersource
{
    using HttpClientTest.Cybersource.Model;

    public interface ICybersourceService
    {
        string GetneratePublicKey(string format, GeneratePublicKeyRequest request);
    }
}
