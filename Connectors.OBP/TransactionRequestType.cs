namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class TransactionRequestType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}