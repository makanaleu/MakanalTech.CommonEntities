using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;
using DateTime = MakanalTech.CommonEntities.DataType.DateTime;
using DayOfWeek = MakanalTech.CommonEntities.Core.Intangible.Enumeration.DayOfWeek;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A structured value providing information about the opening hours of a 
    /// place or a certain service inside a place.
    /// </summary>
    /// <remarks>
    /// The place is open if the opens property is specified, and closed 
    /// otherwise. If the value for the closes property is less than the value
    /// for the opens property then the hour range is assumed to span over the 
    /// next day.
    /// </remarks>
    [DataContract(Name = "OpeningHoursSpecification", Namespace = "https://schema.org/OpeningHoursSpecification")]
    public class OpeningHoursSpecification : Thing
    {
        /// <summary>
        /// The closing hour of the place or service on the given day(s) of the
        /// week. 
        /// </summary>
        /// <example>https://schema.org/closes</example>
        [DataMember(Name = "closes")]
        public Time Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid. 
        /// </summary>
        /// <example>https://schema.org/dayOfWeek</example>
        [DataMember(Name = "dayOfWeek")]
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the
        /// week. 
        /// </summary>
        /// <example>https://schema.org/opens</example>
        [DataMember(Name = "opens")]
        public Time Opens { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        /// <example>https://schema.org/validFrom</example>
        [DataMember(Name = "validFrom")]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of 
        /// an offer, salary period, 
        /// or a period of opening hours.
        /// </summary>
        /// <example>https://schema.org/validThrough</example>
        [DataMember(Name = "validThrough")]
        public DateTime ValidThrough { get; set; }
    }
}
