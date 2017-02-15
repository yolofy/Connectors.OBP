namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class TransactionRequestCharge
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("value")]
        public AmountOfMoney Value { get; set; }
    }
}