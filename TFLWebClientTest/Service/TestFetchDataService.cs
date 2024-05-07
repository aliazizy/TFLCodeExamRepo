using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var response= new HttpResponseMessage()
            {
                Content = new StringContent(await Data.GetData(_roadId), Encoding.UTF8, "application/json")
            };

            return response;
        }
    }
}
