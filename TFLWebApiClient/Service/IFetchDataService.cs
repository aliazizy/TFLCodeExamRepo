
namespace TFLWebApiClient.Service
{
    public interface IFetchDataService
    {
        Task<HttpResponseMessage> FetchData();
    }
}