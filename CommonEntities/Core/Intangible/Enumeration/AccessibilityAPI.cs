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
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// AndroidAccessibility
        /// </summary>
        [EnumMember(Value = "AndroidAccessibility")]
        AndroidAccessibility = 10,

        /// <summary>
        /// ARIA
        /// </summary>
        [EnumMember(Value = "ARIA")]
        ARIA = 20,

        /// <summary>
        /// ATK
        /// </summary>
        [EnumMember(Value = "ATK")]
        ATK = 30,

        /// <summary>
        /// AT-SPI
        /// </summary>
        [EnumMember(Value = "AT-SPI")]
        AT_SPI = 40,

        /// <summary>
        /// BlackberryAccessibility
        /// </summary>
        [EnumMember(Value = "BlackberryAccessibility")]
        BlackberryAccessibility = 50,

        /// <summary>
        /// iAccessible2
        /// </summary>
        [EnumMember(Value = "iAccessible2")]
        iAccessible2 = 60,

        /// <summary>
        /// iOSAccessibility
        /// </summary>
        [EnumMember(Value = "iOSAccessibility")]
        iOSAccessibility = 70,

        /// <summary>
        /// JavaAccessibility
        /// </summary>
        [EnumMember(Value = "JavaAccessibility")]
        JavaAccessibility = 80,

        /// <summary>
        /// MacOSXAccessibility
        /// </summary>
        [EnumMember(Value = "MacOSXAccessibility")]
        MacOSXAccessibility = 90,

        /// <summary>
        /// MSAA
        /// </summary>
        [EnumMember(Value = "MSAA")]
        MSAA = 100,

        /// <summary>
        /// UIAutomation
        /// </summary>
        [EnumMember(Value = "UIAutomation")]
        UIAutomation = 110
    }
}
