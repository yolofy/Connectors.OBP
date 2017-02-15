namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class HyperLink
    {
        [JsonProperty("href")]
        public string URL { get; set; }
    }
}