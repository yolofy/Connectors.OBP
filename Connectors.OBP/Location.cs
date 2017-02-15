namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Location
    {
        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}