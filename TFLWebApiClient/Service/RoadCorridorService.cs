using Newtonsoft.Json;
using TFLWebApiClient.Model;

namespace TFLWebApiClient.Service
{
    public class RoadCorridorService : IRoadCorridorService
    {
        private readonly IFetchDataService _fetchDataService;
        private readonly string _roadId;

        public RoadCorridorService(IFetchDataService fetchDataService, string roadId)
        {
            _fetchDataService = fetchDataService;
            _roadId = roadId;
        }
        public async Task<RoadCorridor> GetRoadCorridorAsync()
        {

            HttpResponseMessage response = await _fetchDataService.FetchData();
            string responseBody = await response.Content.ReadAsStringAsync();
            if (responseBody != null && response.IsSuccessStatusCode)
            {

                IEnumerable<RoadCorridor> roadCorridor = JsonConvert.DeserializeObject<IEnumerable<RoadCorridor>>(responseBody);
                return roadCorridor?.First();
            }
            else
            {
                var responseContent = JsonConvert.DeserializeObject<NotFoundResponse>(responseBody);
                //  RoadCorridor result = new(roadId, roadId, response.ReasonPhrase, (int)response.StatusCode);
                return new RoadCorridor() { Id = _roadId, DisplayName = _roadId, HttpStatusCode = responseContent.httpStatusCode };

            }

        }


    }

    public class NotFoundResponse
    {
        public string message { get; set; }
        public int httpStatusCode { get; set; }
    }
}

