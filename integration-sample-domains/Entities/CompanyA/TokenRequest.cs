using System.Text.Json.Serialization;

namespace integration_sample_domains.Entities.CompanyA
{
    public class TokenRequest
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("instance")]
        public string Instance { get; set; }

        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        [JsonPropertyName("line")]
        public string Line { get; set; }
    }
}