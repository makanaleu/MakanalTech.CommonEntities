using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// Specifies a location feature by providing a structured value 
    /// representing a feature of an accommodation as a property-value pair of 
    /// varying degrees of formality.
    /// </summary>
    [DataContract(Name = "LocationFeatureSpecification", Namespace = "https://schema.org/LocationFeatureSpecification")]
    public class LocationFeatureSpecification : PropertyValue
    {
        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        /// <example>https://schema.org/hoursAvailable</example>
        [DataMember(Name = "hoursAvailable")]
        public OpeningHoursSpecification HoursAvailable { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        /// <example>https://schema.org/validFrom</example>
        [DataMember(Name = "validFrom")]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an
        /// offer, salary period, or a period of opening hours.
        /// </summary>
        /// <example>https://schema.org/validThrough</example>
        [DataMember(Name = "validThrough")]
        public DateTime ValidThrough { get; set; }
    }
}
