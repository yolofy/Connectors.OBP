namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class AccountOwner
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}