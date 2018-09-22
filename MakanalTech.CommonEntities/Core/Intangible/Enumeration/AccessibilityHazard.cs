using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
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
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Flashing
        /// </summary>
        [EnumMember(Value = "flashing")]
        Flashing = 10,

        /// <summary>
        /// NoFlashingHazard
        /// </summary>
        [EnumMember(Value = "noFlashingHazard")]
        NoFlashingHazard = 20,

        /// <summary>
        /// MotionSimulation
        /// </summary>
        [EnumMember(Value = "motionSimulation")]
        MotionSimulation = 30,

        /// <summary>
        /// NoMotionSimulationHazard
        /// </summary>
        [EnumMember(Value = "noMotionSimulationHazard")]
        NoMotionSimulationHazard = 40,

        /// <summary>
        /// Sound
        /// </summary>
        [EnumMember(Value = "sound")]
        Sound = 50,

        /// <summary>
        /// NoSoundHazard
        /// </summary>
        [EnumMember(Value = "noSoundHazard")]
        NoSoundHazard = 60,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 70
    }
}
