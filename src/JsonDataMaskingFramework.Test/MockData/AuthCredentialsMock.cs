using JsonDataMaskingFramework.Attributes;
using System.Text.Json.Serialization;

namespace JsonDataMaskingFramework.Test.MockData
{
    public class AuthCredentialsMock
    {
        [SensitiveData]
        [JsonPropertyName("apiKey")]
        public object ApiKey { get; set; }

        [SensitiveData]
        [JsonPropertyName("apiToken")]
        public string ApiToken { get; set; }
    }
}
