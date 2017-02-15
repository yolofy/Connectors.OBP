namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Role
    {
        [JsonProperty("role")]
        public string Name { get; set; }

        [JsonProperty("requires_bank_id")]
        public bool RequiresBankId { get; set; }
    }
}