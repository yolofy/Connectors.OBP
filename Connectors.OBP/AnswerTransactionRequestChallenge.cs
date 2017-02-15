namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class AnswerTransactionRequestChallenge
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }
    }
}