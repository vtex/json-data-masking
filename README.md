# JSON Data Masking Framework

JSON Data Masking is a library for .NET Framework applications that simplifies the masking process of PII/sensitive information.

## Disclaimer

For .NET Core applications, you can use the original [JSON Data Masking](https://www.nuget.org/packages/JsonDataMasking/) library whose repository is [this one](https://github.com/luizaes/json-data-masking).

## Usage

After installing the Nuget package in your project, you need to take the following steps:

1. Add the `[SensitiveData]` attribute in your class properties to indicate what should be masked, and use its available fields to configure the masking:

    - **PreserveLength**: Set to `true` to keep the property length when masking its value. By default this setting is set to `false`.
    - **ShowFirst**: If set, shows the first `N` characters of the property, not masking them. The default value is 0.
    - **ShowLast**: If set, shows the last `N` characters of the property, not masking them. The default value is 0.
    - **SubstituteText**: If set, the entire property value will be override with this text. Note that using this setting will ignore all other settings.
    - **Mask**: Set to a character to use it when masking the property's value. By default, the character `*` is used.

2. Call the `JsonMask.MaskSensitiveData()` function, passing in your object instance as a parameter.

## Support

This library supports masking of `string` fields only, although it also supports `List<string>`/`IEnumerable<string>` and `Dictionary<string, string>`. Nested class properties are also masked, independently of depth. 

| Property Type 	| Support 	|
|:---:	|:---:	|
| string 	| ✅ 	|
| List\<T>, where T is a class or string 	| ✅ 	|
| IEnumerable\<T>, where T is a class or string 	| ✅ 	|
| Dictionary<string, string> 	| ✅ 	|
| Any other collection type, such as Array, ArrayList\<T>, etc 	| ❌ 	|
| Any other base type different from string 	| ❌ 	|

## Examples

### Attributes
```csharp
public class PropertiesExamples
{
    /// 123456789 results in "*****"
    [SensitiveData]
    public string DefaultMask { get; set; }

    /// 123456789 results in "REDACTED"
    [SensitiveData(SubstituteText = "REDACTED")]
    public string SubstituteMask { get; set; }

    /// 123456789 results in "123*****789"
    [SensitiveData(ShowFirst = 3, ShowLast = 3)]
    public string ShowCharactersMask { get; set; }

    /// 123456789 results in "#########"
    [SensitiveData(PreserveLength = true, Mask = "#")]
    public string PreserveCustomMask { get; set; }
}
```

### Functions
```csharp
var maskedData = JsonMask.MaskSensitiveData(data);
```

## Dependencies
- [DeepCloner](https://github.com/force-net/DeepCloner)