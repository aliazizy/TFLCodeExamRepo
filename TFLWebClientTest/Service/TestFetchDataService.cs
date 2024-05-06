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

        public HttpResponseMessage FetchData()
        {
            var response= new HttpResponseMessage()
            {
                Content = new StringContent(Data.GetData(_roadId), Encoding.UTF8, "application/json")
            };

            return response;
        }

        Task<HttpResponseMessage> IFetchDataService.FetchData()
        {
            throw new NotImplementedException();
        }
    }
}
