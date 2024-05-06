using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TFLWebApiClient.Model;
using TFLWebApiClient.Service;

internal class Program
{

    private static async Task Main(string[] args)
    {

        // Create a new configuration object.
        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        // Get values from the config given their key and their target type.
        Settings? settings = config.GetRequiredSection("Settings").Get<Settings>();
        var fetchDataService = new FetchDataService(HttpClientFactory.CreateHttpClient(), settings, args[0]);
        var roadCorridorService = new RoadCorridorService(fetchDataService, args[0]);

        var result = await roadCorridorService.GetRoadCorridorAsync();
        if (result.HttpStatusCode == 404)
            Console.WriteLine($"{result.Id} is not a valid road");
        else
        {
            Console.WriteLine($"The status of the {result.DisplayName} is as follows");
            Console.WriteLine($"Road Status is {result.StatusSeverity}");
            Console.WriteLine($"Road Status Description is {result.StatusSeverityDescription}");
        }
        Console.WriteLine("Hit ENTER to exit...");
        Console.ReadLine();
    }
}