namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class TransactionCore
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("account")]
        public Account Acount { get; set; }

        [JsonProperty("counterparty")]
        public Counterparty Counterparty { get; set; }

        [JsonProperty("details")]
        public TransactionDetails Details { get; set; }
    }
}