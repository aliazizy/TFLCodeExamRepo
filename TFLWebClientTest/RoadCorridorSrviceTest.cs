using TFLWebApiClient.Service;
using TFLWebClientTest.Service;

namespace TFLWebClientTest
{
    [TestClass]
    public class RoadCorridorSrviceTest
    {
        [TestMethod]
        public async Task ValidRoadId()
        {
            var fetchDataService = new TestFetchDataService("A2");
            var roadCorridorService = new RoadCorridorService(fetchDataService,"A2");
            var result = await roadCorridorService.GetRoadCorridorAsync();
            Assert.AreEqual("A2".ToUpper(), result.DisplayName.ToUpper());
            Assert.AreEqual("A2".ToUpper(), result.Id.ToUpper());
            Assert.IsNotNull(result.StatusSeverity);
            Assert.IsNotNull(result.StatusSeverityDescription);
            
        }
        [TestMethod]
        public async Task NotValidRoadId()
        {
            var fetchDataService = new TestFetchDataService("A233");
            var roadCorridorService = new RoadCorridorService(fetchDataService, "A233");
            var result = await roadCorridorService.GetRoadCorridorAsync();
            Assert.AreEqual(404, result.HttpStatusCode);
           

        }
    }
}
