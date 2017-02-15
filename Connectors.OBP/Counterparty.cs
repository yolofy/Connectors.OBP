namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Counterparty
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("holder")]
        public Holder Holder { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("kind")]
        public object Kind { get; set; }

        [JsonProperty("IBAN")]
        public object IBAN { get; set; }

        [JsonProperty("swift_bic")]
        public object SwiftBic { get; set; }

        [JsonProperty("bank")]
        public MinimumBank Bank { get; set; }
    }
}