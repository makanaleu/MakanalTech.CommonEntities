using CommonEntities.Core;
using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Combo
{
    /// <summary>
    /// GeoShapePlaceOrText MultiType accepts a GeoShape, Place, or Text (string).
    /// </summary>
    /// <example>https://schema.org/ineligibleRegion</example>
    [DataContract(Name = "GeoShapePlaceOrText", Namespace = "CommonEntities.MultiType.Combo")]
    public class GeoShapePlaceOrText : Text
    {
        /// <summary>
        /// GeoShapePlaceOrText as a GeoShape.
        /// </summary>
        [DataMember(Name = "asGeoShape")]
        public GeoShape AsGeoShape;

        /// <summary>
        /// GeoShapePlaceOrText as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace;

        /// <summary>
        /// GeoShapePlaceOrText as a GeoShape.
        /// </summary>
        /// <param name="geoShape">GeoShapePlaceOrText as a GeoShape.</param>
        public GeoShapePlaceOrText(GeoShape geoShape) 
            : base(geoShape.Name.AsText)
        {
            AsGeoShape = geoShape;
        }

        /// <summary>
        /// GeoShapePlaceOrText as a Place.
        /// </summary>
        /// <param name="place">GeoShapePlaceOrText as a Place.</param>
        public GeoShapePlaceOrText(Place place) : base(place.Name.AsText)
        {
            AsPlace = place;
        }

        /// <summary>
        /// GeoShapePlaceOrText as Text (string).
        /// </summary>
        /// <param name="text">GeoShapePlaceOrText as Text (string).</param>
        public GeoShapePlaceOrText(string text) : base(text) { }

        /// <summary>
        /// GeoShapePlaceOrText.
        /// </summary>
        public GeoShapePlaceOrText() : base() { }
    }
}
