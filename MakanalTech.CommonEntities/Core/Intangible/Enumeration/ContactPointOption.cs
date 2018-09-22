using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// </summary>
    [DataContract(Name = "ContactPointOption", Namespace = "https://schema.org/ContactPointOption")]
    public enum ContactPointOption
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Uses devices to support users with hearing impairments.
        /// </summary>
        /// <example>https://schema.org/HearingImpairedSupported</example>
        [EnumMember(Value = "HearingImpairedSupported")]
        HearingImpairedSupported = 10,

        /// <summary>
        /// The associated telephone number is toll free.
        /// </summary>
        /// <example>https://schema.org/TollFree</example>
        [EnumMember(Value = "TollFree")]
        TollFree = 20
    }
}
