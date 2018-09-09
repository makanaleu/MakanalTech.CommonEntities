using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Indicates that the resource is compatible with the referenced 
    /// accessibility API.
    /// </summary>
    /// <remarks>
    /// WebSchemas wiki lists possible values: 
    /// http://www.w3.org/wiki/WebSchemas/Accessibility
    /// </remarks>
    [DataContract(Name = "AccessibilityAPI", Namespace = "https://schema.org/accessibilityAPI")]
    public enum AccessibilityAPI
    {
        [EnumMember(Value = "AndroidAccessibility")]
        AndroidAccessibility = 10,

        [EnumMember(Value = "ARIA")]
        ARIA = 20,

        [EnumMember(Value = "ATK")]
        ATK = 30,

        [EnumMember(Value = "AT-SPI")]
        AT_SPI = 40,

        [EnumMember(Value = "BlackberryAccessibility")]
        BlackberryAccessibility = 50,

        [EnumMember(Value = "iAccessible2")]
        iAccessible2 = 60,

        [EnumMember(Value = "iOSAccessibility")]
        iOSAccessibility = 70,

        [EnumMember(Value = "JavaAccessibility")]
        JavaAccessibility = 80,

        [EnumMember(Value = "MacOSXAccessibility")]
        MacOSXAccessibility = 90,

        [EnumMember(Value = "MSAA")]
        MSAA = 100,

        [EnumMember(Value = "UIAutomation")]
        UIAutomation = 110
    }
}
