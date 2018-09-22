using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The predominant mode of learning supported by the learning resource.
    /// </summary>
    [DataContract(Name = "InteractivityType", Namespace = "https://schema.org/interactivityType")]
    public enum InteractivityType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 10,

        /// <summary>
        /// Expositive
        /// </summary>
        [EnumMember(Value = "expositive")]
        Expositive = 20,

        /// <summary>
        /// Mixed
        /// </summary>
        [EnumMember(Value = "mixed")]
        Mixed = 30
    }
}
