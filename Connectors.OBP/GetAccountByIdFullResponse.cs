namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class GetAccountByIdFullResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("owners")]
        public AccountOwner[] Owners { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("balance")]
        public AmountOfMoney Balance { get; set; }

        [JsonProperty("IBAN")]
        public string IBAN { get; set; }

        [JsonProperty("swift_bic")]
        public string SwiftBic { get; set; }

        [JsonProperty("views_available")]
        public View[] ViewsAvailable { get; set; }
    
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
    }
}