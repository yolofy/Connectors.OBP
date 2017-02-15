namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class CreateTransactionRequest
    {
        [JsonProperty("to")]
        public BankAccountReference To { get; set; }

        [JsonProperty("value")]
        public AmountOfMoney Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

    }
}