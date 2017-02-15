namespace Connectors.OBP
{
    using Newtonsoft.Json;

    public class GetAccountsAtAllBanksPublicResponse
    {
        [JsonProperty("accounts")]
        public AccountInfo[] Accounts { get; set; }
    }
}