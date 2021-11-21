using System.Text.Json.Serialization;

namespace integration_sample_domains.Entities.CompanyB
{
    public class TokenRequest
    {
        [JsonPropertyName("auth_type")]
        public string AuthType { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}