using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// GeoCoordinatesOrGeoShape MultiType accepts GeoCoordinates or GeoShape.
    /// </summary>
    /// <example>https://schema.org/geo</example>
    [DataContract(Name = "GeoCoordinatesOrGeoShape", Namespace = "CommonEntities.MultiType.Alt")]
    public class GeoCoordinatesOrGeoShape
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string? ApplicationKey { get; set; }

        /// <summary>
        /// GeoCoordinatesOrGeoShape as GeoCoordinates.
        /// </summary>
        [DataMember(Name = "asGeoCoordinates")]
        public GeoCoordinates AsGeoCoordinates { get; set; }

        /// <summary>
        /// GeoCoordinatesOrGeoShape as a GeoShape.
        /// </summary>
        [DataMember(Name = "asGeoShape")]
        public GeoShape AsGeoShape { get; set; }

        /// <summary>
        /// GeoCoordinatesOrGeoShape as GeoCoordinates.
        /// </summary>
        /// <param name="geoCoordinates">GeoCoordinatesOrGeoShape as GeoCoordinates.</param>
        public GeoCoordinatesOrGeoShape(GeoCoordinates geoCoordinates)
        {
            AsGeoCoordinates = geoCoordinates;
        }

        /// <summary>
        /// GeoCoordinatesOrGeoShape as a GeoShape.
        /// </summary>
        /// <param name="geoShape">GeoCoordinatesOrGeoShape as a GeoShape.</param>
        public GeoCoordinatesOrGeoShape(GeoShape geoShape)
        {
            AsGeoShape = geoShape;
        }

        /// <summary>
        /// GeoCoordinatesOrGeoShape.
        /// </summary>
        public GeoCoordinatesOrGeoShape() { }
    }
}
