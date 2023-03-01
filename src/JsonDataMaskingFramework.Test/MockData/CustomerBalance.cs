using JsonDataMaskingFramework.Attributes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JsonDataMaskingFramework.Test.MockData
{
    public class CustomerBalance
    {
        [SensitiveData]
        [JsonPropertyName("accountsBalance")]
        public Dictionary<string, int> AccountsBalance { get; set; }
    }
}
