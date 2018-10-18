using MakanalTech.CommonEntities.Pending;
using System;
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
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// GeospatialGeometryOrPlace as a GeospatialGeometry.
        /// </summary>
        [DataMember(Name = "asGeospatialGeometry")]
        public GeospatialGeometry AsGeospatialGeometry { get; set; }

        /// <summary>
        /// GeospatialGeometryOrPlace as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace { get; set; }

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
