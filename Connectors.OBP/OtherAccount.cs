namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class OtherAccount
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("holder")]
        public Holder Holder { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("IBAN")]
        public string IBAN { get; set; }

        [JsonProperty("swift_bic")]
        public string SwiftBic { get; set; }

        [JsonProperty("bank")]
        public MinimumBank MinimumBank { get; set; }

        [JsonProperty("metadata")]
        public OtherAccountMetadata Metadata { get; set; }
    }
}