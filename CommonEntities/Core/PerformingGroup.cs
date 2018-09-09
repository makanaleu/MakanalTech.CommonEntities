using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// </summary>
    [DataContract(Name = "PerformingGroup", Namespace = "https://schema.org/PerformingGroup")]
    public class PerformingGroup : Organization
    {
    }
}
