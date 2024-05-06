

namespace TFLWebClientTest.Stub
{
    public static class Data
    {
        public static string GetData(string key)
        {
            RoadCorridorData["A2"] = "{StatusCode: 200, ReasonPhrase: 'OK', Version: 1.1, Content: System.Net.Http.HttpConnectionResponseContent, Headers:\r\n{\r\n  Date: Mon, 06 May 2024 21:54:17 GMT\r\n  Transfer-Encoding: chunked\r\n  Connection: keep-alive\r\n  Cache-Control: public, must-revalidate, max-age=150, s-maxage=300\r\n  Via: 1.1 varnish\r\n  Age: 0\r\n  Access-Control-Allow-Headers: Content-Type\r\n  Access-Control-Allow-Methods: GET,POST,PUT,DELETE,OPTIONS\r\n  Access-Control-Allow-Origin: *\r\n  Api-Entity-Payload: RoadCorridor\r\n  X-Backend: api\r\n  X-Cache: MISS\r\n  X-Cacheable: Yes. Cacheable\r\n  X-Frame-Options: deny\r\n  X-Proxy-Connection: unset\r\n  X-TTL: 300.000\r\n  X-TTL-RULE: 0\r\n  X-Varnish: 2023958141\r\n  X-AspNet-Version: 4.0.30319\r\n  X-Operation: Road_GetByPathIds\r\n  X-API: Road\r\n  CF-Cache-Status: DYNAMIC\r\n  Strict-Transport-Security: max-age=31536000\r\n  Set-Cookie: _cfuvid=65qT6afraWSi1AMFd6UQjIWKUK_BVS7U7gUS5QRPS.o-1715032457723-0.0.1.1-604800000; path=/; domain=.tfl.gov.uk; HttpOnly; Secure; SameSite=None\r\n  Server: cloudflare\r\n  CF-RAY: 87fc353c689276cc-LHR\r\n  Content-Type: application/json; charset=utf-8\r\n}}";
            RoadCorridorData.Add("A233", "{StatusCode: 404, ReasonPhrase: 'Not Found', Version: 1.1, Content: System.Net.Http.HttpConnectionResponseContent, Headers:\r\n{\r\n  Date: Mon, 06 May 2024 21:57:13 GMT\r\n  Transfer-Encoding: chunked\r\n  Connection: keep-alive\r\n  Cache-Control: must-revalidate, max-age=60, s-maxage=60\r\n  Pragma: no-cache\r\n  Via: 1.1 varnish\r\n  Age: 0\r\n  Access-Control-Allow-Headers: Content-Type\r\n  Access-Control-Allow-Methods: GET,POST,PUT,DELETE,OPTIONS\r\n  Access-Control-Allow-Origin: *\r\n  x-backend: api\r\n  X-Cache: MISS\r\n  x-host: api.digital.tfl.gov.uk\r\n  X-No-Smaxage: true\r\n  X-Proxy-Connection: unset\r\n  X-Request-404: true\r\n  X-TTL-RULE: 1\r\n  X-Varnish: 2546395676\r\n  X-AspNet-Version: 4.0.30319\r\n  X-Operation: Road_GetByPathIds\r\n  X-API: Road\r\n  CF-Cache-Status: DYNAMIC\r\n  Strict-Transport-Security: max-age=31536000\r\n  Set-Cookie: _cfuvid=XxBdrnoPglduEg6sR_2jA05ZW01aDJHBthKhRVPmNPo-1715032633636-0.0.1.1-604800000; path=/; domain=.tfl.gov.uk; HttpOnly; Secure; SameSite=None\r\n  Server: cloudflare\r\n  CF-RAY: 87fc3987ddb863f8-LHR\r\n  Content-Type: application/json; charset=utf-8\r\n  Expires: -1\r\n}}");
            return RoadCorridorData[key];
        }
        public static Dictionary<string, string> RoadCorridorData = new();

    }
}
