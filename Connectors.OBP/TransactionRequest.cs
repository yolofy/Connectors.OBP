namespace Connectors.OBP
{
    using System;

    using Newtonsoft.Json;

    public class TransactionRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public TransactionRequestAccount From { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("transaction_ids")]
        public string TransactionIds { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("challenge")]
        public Challenge Challenge { get; set; }

        [JsonProperty("charge")]
        public TransactionRequestCharge Charge { get; set; }
    }
}