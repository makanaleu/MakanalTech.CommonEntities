using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Identifies input methods that are sufficient to fully control the 
    /// described resource.
    /// </summary>
    /// <remarks>
    /// WebSchemas wiki lists possible values:
    /// http://www.w3.org/wiki/WebSchemas/Accessibility
    /// </remarks>
    [DataContract(Name = "AccessibilityControl", Namespace = "https://schema.org/accessibilityControl")]
    public enum AccessibilityControl
    {
        /// <summary>
        /// Sufficient control of resource is possible via keyboard.
        /// </summary>
        [EnumMember(Value = "fullKeyboardControl")]
        FullKeyboardControl = 10,

        /// <summary>
        /// Sufficient control of resource is possible via mouse.
        /// </summary>
        [EnumMember(Value = "fullMouseControl")]
        FullMouseControl = 20,

        /// <summary>
        /// Sufficient control of resource is possible via switch.
        /// </summary>
        [EnumMember(Value = "fullSwitchControl")]
        FullSwitchControl = 30,

        /// <summary>
        /// Sufficient control of resource is possible via touch.
        /// </summary>
        [EnumMember(Value = "fullTouchControl")]
        FullTouchControl = 40,

        /// <summary>
        /// Sufficient control of resource is possible via video.
        /// </summary>
        [EnumMember(Value = "fullVideoControl")]
        FullVideoControl = 50,

        /// <summary>
        /// Sufficient control of resource is possible via voice.
        /// </summary>
        [EnumMember(Value = "fullVoiceControl")]
        FullVoiceControl = 60
    }
}
