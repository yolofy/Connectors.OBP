namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class AccountInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public object Label { get; set; }

        [JsonProperty("bank_id")]
        public string BankId { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}