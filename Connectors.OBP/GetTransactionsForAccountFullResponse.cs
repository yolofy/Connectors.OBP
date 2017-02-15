namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class GetTransactionsForAccountFullResponse
    {
        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }
    }
}