namespace Connectors.OBP
{
    using System;

    using Newtonsoft.Json;

    public class Comment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}