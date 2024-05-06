using TFLWebApiClient.Service;
using TFLWebClientTest.Service;

namespace TFLWebClientTest
{
    [TestClass]
    public class RoadCorridorSrviceTest
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var fetchDataService = new TestFetchDataService("A2");
            var roadCorridorService = new RoadCorridorService(fetchDataService,"A2");
            var result = await roadCorridorService.GetRoadCorridorAsync();
            Assert.AreEqual("A2", result.DisplayName);
            Assert.AreEqual("A2", result.Id);
            Assert.AreEqual("good", result.StatusSeverity);
            Assert.AreEqual("No Exceptional Delays", result.StatusSeverityDescription);
            
        }
    }
}
