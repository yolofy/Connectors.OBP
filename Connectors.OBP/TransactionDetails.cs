namespace Connectors.OBP
{
    using System;

    using Newtonsoft.Json;

    public class TransactionDetails
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("posted")]
        public DateTime Posted { get; set; }

        [JsonProperty("completed")]
        public DateTime Completed { get; set; }

        [JsonProperty("new_balance")]
        public AmountOfMoney NewBalance { get; set; }

        [JsonProperty("value")]
        public AmountOfMoney Value { get; set; }
    }
}