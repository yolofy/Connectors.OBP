namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class TransactionMetaData
    {
        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("comments")]
        public Comment[] Comments { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("where")]
        public Location Where { get; set; }
    }
}