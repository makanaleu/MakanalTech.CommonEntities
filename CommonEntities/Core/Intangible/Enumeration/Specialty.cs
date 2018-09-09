using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Any branch of a field in which people typically develop specific 
    /// expertise, usually after significant study, time, and effort.
    /// </summary>
    [DataContract(Name = "Specialty", Namespace = "https://schema.org/Specialty")]
    public class Specialty : Thing
    {
    }
}
