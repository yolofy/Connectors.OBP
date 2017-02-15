namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Transaction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("this_account")]
        public ThisAccount ThisAccount { get; set; }

        [JsonProperty("other_account")]
        public OtherAccount OtherAccount { get; set; }

        [JsonProperty("details")]
        public TransactionDetails Details { get; set; }

        [JsonProperty("metadata")]
        public TransactionMetaData Metadata { get; set; }
    }
}