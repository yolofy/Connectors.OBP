namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class CreateTransactionRequestRequest
    {
        [JsonProperty("to")]
        public TransactionRequestAccount To { get; set; }

        [JsonProperty("value")]
        public AmountOfMoney Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}