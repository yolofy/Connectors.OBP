namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("URL")]
        public string URL { get; set; }
    }
}