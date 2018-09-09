using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Quantity
{
    /// <summary>
    /// Properties that take Distances as values (e.g. `7 ft`).
    /// </summary>
    [DataContract(Name = "Distance", Namespace = "https://schema.org/Distance")]
    public class Distance : Thing
    {
    }
}
