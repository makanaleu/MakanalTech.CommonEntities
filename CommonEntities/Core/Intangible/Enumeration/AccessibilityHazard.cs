using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// A characteristic of the described resource that is physiologically 
    /// dangerous to some users.
    /// </summary>
    /// <remarks>
    /// If none of the hazards are known to exist instead of calling out each 
    /// nonHazard it is recommended to use "none". If the content has hazard(s),
    /// include positive assertions for the hazards it has and negative 
    /// assertions for the others.
    /// </remarks>
    [DataContract(Name = "AccessibilityHazard", Namespace = "https://schema.org/accessibilityHazard")]
    public enum AccessibilityHazard
    {
        [EnumMember(Value = "flashing")]
        Flashing = 10,

        [EnumMember(Value = "noFlashingHazard")]
        NoFlashingHazard = 20,

        [EnumMember(Value = "motionSimulation")]
        MotionSimulation = 30,

        [EnumMember(Value = "noMotionSimulationHazard")]
        NoMotionSimulationHazard = 40,

        [EnumMember(Value = "sound")]
        Sound = 50,

        [EnumMember(Value = "noSoundHazard")]
        NoSoundHazard = 60,

        [EnumMember(Value = "unknown")]
        Unknown = 70,

        [EnumMember(Value = "none")]
        None = 90
    }
}
