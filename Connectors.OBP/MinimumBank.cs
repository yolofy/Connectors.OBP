namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class MinimumBank
    {
        [JsonProperty("national_identifier")]
        public string NationalIdentifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}