using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Quantity
{
    /// <summary>
    /// Quantity: Duration (use ISO 8601 duration format).
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/ISO_8601#Durations
    /// </remarks>
    [DataContract(Name = "Duration", Namespace = "https://schema.org/Duration")]
    public class Duration : Thing
    {
    }
}
