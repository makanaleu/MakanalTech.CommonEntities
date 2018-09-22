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
        /// GeoCoordinatesOrGeoShape as GeoCoordinates.
        /// </summary>
        [DataMember(Name = "asGeoCoordinates")]
        public GeoCoordinates AsGeoCoordinates;

        /// <summary>
        /// GeoCoordinatesOrGeoShape as a GeoShape.
        /// </summary>
        [DataMember(Name = "asGeoShape")]
        public GeoShape AsGeoShape;

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
