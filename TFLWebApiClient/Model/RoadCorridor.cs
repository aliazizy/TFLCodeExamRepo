namespace TFLWebApiClient.Model
{
    public class RoadCorridor
    {
        public RoadCorridor() { }
        public RoadCorridor(string id, string displayName, int httpStatusCode, string? httpStatus)
        {
            Id = id;
            DisplayName = displayName;
            HttpStatus = httpStatus;
            HttpStatusCode = httpStatusCode;
        }

        public string? Type { get; set; }
        public required string Id { get; set; }
        public required string DisplayName { get; set; }
        public string? StatusSeverity { get; set; }
        public string? StatusSeverityDescription { get; set; }
        public string? Bounds { get; set; }
        public string? Envelope { get; set; }
        public string? Url { get; set; }
        public string? HttpStatus { get; set; }
        public int HttpStatusCode { get; set; }
    }
}
