using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The predominant mode of learning supported by the learning resource.
    /// </summary>
    [DataContract(Name = "InteractivityType", Namespace = "https://schema.org/interactivityType")]
    public enum InteractivityType
    {
        [EnumMember(Value = "active")]
        Active = 10,

        [EnumMember(Value = "expositive")]
        Expositive = 20,

        [EnumMember(Value = "mixed")]
        Mixed = 30
    }
}
