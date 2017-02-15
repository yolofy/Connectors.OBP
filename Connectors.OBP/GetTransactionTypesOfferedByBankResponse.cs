namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class GetTransactionTypesOfferedByBankResponse
    {
        [JsonProperty("transaction_types")]
        public TransactionType[] TransactionTypes { get; set; }
    }
}