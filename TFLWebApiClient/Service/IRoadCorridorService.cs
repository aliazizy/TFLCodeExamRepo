using TFLWebApiClient.Model;

namespace TFLWebApiClient.Service
{
    public interface IRoadCorridorService
    {
        Task<RoadCorridor> GetRoadCorridorAsync();
    }
}