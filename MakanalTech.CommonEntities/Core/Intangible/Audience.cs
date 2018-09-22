using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was 
    /// created.
    /// </summary>
    [DataContract(Name = "Audience", Namespace = "https://schema.org/Audience")]
    public class Audience : Thing
    {
        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, 
        /// car owners, musicians, etc.).
        /// </summary>
        /// <example>https://schema.org/audienceType</example>
        [DataMember(Name = "audienceType")]
        public Text AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        /// <example>https://schema.org/geographicArea</example>
        [DataMember(Name = "geographicArea")]
        public AdministrativeArea GeographicArea { get; set; }
    }
}
