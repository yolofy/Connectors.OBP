namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class TransactionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        [JsonProperty("short_code")]
        public string ShortCode { get; set; }
        [JsonProperty("summary")]
        public  string Summary { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("charge")]
        public AmountOfMoney Charge { get; set; }
    }
}