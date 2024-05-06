using System;
using System.Collections.Generic;
using System.Linq;

using TFLWebApiClient.Model;

namespace TFLWebApiClient.Service
{
    public class FetchDataService : IFetchDataService
    {
        private HttpClient _httpClient;
        private readonly string _roadId;
        private string _remoteServiceBaseUrl;
        private string _appId;
        private string _appKey;

        public FetchDataService(HttpClient httpClient, Settings settings, string roadId)
        {
            _httpClient = httpClient;
            _roadId = roadId;
            _remoteServiceBaseUrl = settings.BaseUrl;
            _appId = settings.AppId;
            _appKey = settings.AppKey;
        }
        

        public async Task<HttpResponseMessage> FetchData()
        {
            using (_httpClient)
            {
                try
                {
                    var uri = $"{_remoteServiceBaseUrl}{_roadId}?app_id ={_appId}&app_key ={_appKey}";
                    var response = await _httpClient.GetAsync(uri);
                    return response;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
        }

    }
}
