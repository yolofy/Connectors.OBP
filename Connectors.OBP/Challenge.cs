namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class Challenge
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("allowed_attempts")]
        public int AllowedAttempts { get; set; }

        [JsonProperty("challenge_type")]
        public string ChallengeType { get; set; }
    }
}