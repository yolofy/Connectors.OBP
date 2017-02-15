namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class GetTransactionRequestsResponse
    {
        [JsonProperty("transaction_requests_with_charges")]
        public TransactionRequest[] TransactionRequestWithCharges { get; set; }
    }
}