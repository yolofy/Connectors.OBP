namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class AmountOfMoney
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}