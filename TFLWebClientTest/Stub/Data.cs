

namespace TFLWebClientTest.Stub
{
    public static class Data
    {
        public static async Task<string> GetData(string key)
        {
            string content = await File.ReadAllTextAsync($".\\{key}.txt");
            return content;
        }

    }
}
