namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class GetTransactionsForAccountCoreResponse
    {
        [JsonProperty("transactions")]
        public TransactionCore[] Transactions { get; set; }
    }
}