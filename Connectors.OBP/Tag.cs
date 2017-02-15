namespace Connectors.OBP
{
    using System;

    using Newtonsoft.Json;

    public class Tag
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}