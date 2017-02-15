namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class GetRolesResponse
    {
        [JsonProperty("roles")]
        public Role[] Roles { get; set; }
    }
}