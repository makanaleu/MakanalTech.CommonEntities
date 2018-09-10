using CommonEntities.Core;
using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType
{
    /// <summary>
    /// Area MultiType accepts either AdministrativeArea, GeoShape, Place, or Text.
    /// </summary>
    [DataContract(Name = "Area", Namespace = "CommonEntities.MultiType")]
    public class Area : Text
    {
        /// <summary>
        /// Area as an AdministrativeArea.
        /// </summary>
        [DataMember(Name = "asAdministrativeArea")]
        public AdministrativeArea AsAdministrativeArea;

        /// <summary>
        /// Area as a GeoShape.
        /// </summary>
        [DataMember(Name = "asGeoShape")]
        public GeoShape AsGeoShape;

        /// <summary>
        /// Area as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace;

        /// <summary>
        /// Area as an AdministrativeArea.
        /// </summary>
        /// <param name="area">Area as an AdministrativeArea.</param>
        public Area(AdministrativeArea area) : base(area.Name.AsText)
        {
            AsAdministrativeArea = area;
        }

        /// <summary>
        /// Area as a GeoShape.
        /// </summary>
        /// <param name="area">Area as a GeoShape.</param>
        public Area(GeoShape area) : base(area.Name.AsText)
        {
            AsGeoShape = area;
        }

        /// <summary>
        /// Area as a Place.
        /// </summary>
        /// <param name="area">Area as a Place.</param>
        public Area(Place area) : base(area.Name.AsText)
        {
            AsPlace = area;
        }

        /// <summary>
        /// Area as Text (string).
        /// </summary>
        /// <param name="area">Area as Text (string).</param>
        public Area(string area) : base(area) { }

        /// <summary>
        /// Area.
        /// </summary>
        public Area() : base() { }
    }
}
