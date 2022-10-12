using System.Threading.Tasks;

namespace HttpClientTest.AdyenClient.Services
{
    public interface IAdyenService
    {
        Task<string> Pay();
    }
}
