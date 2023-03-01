using JsonDataMaskingFramework.Attributes;
using System.Text.Json.Serialization;

namespace JsonDataMaskingFramework.Test.MockData
{
    public class CreditCardMock
    {
        [SensitiveData]
        [JsonPropertyName("securityCode")]
        public int SecurityCode { get; set; }
    }
}
