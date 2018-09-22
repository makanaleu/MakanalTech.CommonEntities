using MakanalTech.CommonEntities.Pending;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// GeospatialGeometryOrPlace MultiType accepts either GeospatialGeometry or Place.
    /// </summary>
    /// <example>https://pending.schema.org/geospatiallyContains</example>
    [DataContract(Name = "GeospatialGeometryOrPlace", Namespace = "CommonEntities.MultiType.Alt")]
    public class GeospatialGeometryOrPlace
    {
        /// <summary>
        /// GeospatialGeometryOrPlace as a GeospatialGeometry.
        /// </summary>
        [DataMember(Name = "asGeospatialGeometry")]
        public GeospatialGeometry AsGeospatialGeometry;

        /// <summary>
        /// GeospatialGeometryOrPlace as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace;

        /// <summary>
        /// GeospatialGeometryOrPlace as a GeospatialGeometry.
        /// </summary>
        /// <param name="geospatialGeometry">GeospatialGeometryOrPlace as a GeospatialGeometry.</param>
        public GeospatialGeometryOrPlace(GeospatialGeometry geospatialGeometry)
        {
            AsGeospatialGeometry = geospatialGeometry;
        }

        /// <summary>
        /// GeospatialGeometryOrPlace as a Place.
        /// </summary>
        /// <param name="place">GeospatialGeometryOrPlace as a Place.</param>
        public GeospatialGeometryOrPlace(Place place)
        {
            AsPlace = place;
        }

        /// <summary>
        /// GeospatialGeometryOrPlace.
        /// </summary>
        public GeospatialGeometryOrPlace() { }
    }
}
