using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFLWebApiClient.Model;

namespace TFLWebApiClient.Service
{
    public static class HttpClientFactory
    {
        public static HttpClient CreateHttpClient()
        {
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();

            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            HttpClient client = httpClientFactory.CreateClient();
            return client;
        }
    }
}
