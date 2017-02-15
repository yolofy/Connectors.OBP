namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Links
    {
        [JsonProperty("self")]
        public HyperLink Self { get; set; }

        [JsonProperty("_new")]
        public HyperLink New { get; set; }
    }
}