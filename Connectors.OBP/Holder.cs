namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Holder
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_alias")]
        public bool IsAlias { get; set; }
    }
}