namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class TransactionRequestAccount
    {
        [JsonProperty("bank_id")]
        public string BankId { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }
}