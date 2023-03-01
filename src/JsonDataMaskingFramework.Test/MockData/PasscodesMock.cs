using JsonDataMaskingFramework.Attributes;

namespace JsonDataMaskingFramework.Test.MockData
{
    public class PasscodesMock
    {
        [SensitiveData]
        public string[] Passcodes { get; set; }
    }
}
