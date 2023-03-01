﻿using JsonDataMaskingFramework.Attributes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JsonDataMaskingFramework.Test.MockData
{
    public class CustomerAddressMock
    {
        [SensitiveData]
        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("geoCoordinates")]
        public List<double> GeoCoordinates { get; set; }
    }
}
