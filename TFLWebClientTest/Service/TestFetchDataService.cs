using System.Text;
using TFLWebApiClient.Service;
using TFLWebClientTest.Stub;

namespace TFLWebClientTest.Service
{
    internal class TestFetchDataService : IFetchDataService
    {
        private readonly string _roadId;

        public TestFetchDataService(string roadId)
        {
            _roadId = roadId;
        }

        public async Task<HttpResponseMessage> FetchData()
        {
            string content = await Data.GetData(_roadId);
            var response= new HttpResponseMessage()
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            return response;
        }
    }
}
