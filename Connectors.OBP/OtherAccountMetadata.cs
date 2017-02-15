namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class OtherAccountMetadata
    {
        [JsonProperty("public_alias")]
        public string PublicAlias { get; set; }

        [JsonProperty("private_alias")]
        public string PrivateAlias { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("URL")]
        public string URL { get; set; }

        [JsonProperty("image_URL")]
        public string ImageUrl { get; set; }

        [JsonProperty("open_corporates_URL")]
        public string OpenCorporatesURL { get; set; }

        [JsonProperty("corporate_location")]
        public Location CorporateLocation { get; set; }

        [JsonProperty("physical_location")]
        public Location PhysicalLocation { get; set; }
    }
}