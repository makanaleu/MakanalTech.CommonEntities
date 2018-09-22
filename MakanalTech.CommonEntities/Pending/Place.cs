using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.Place.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Place", Namespace = "https://pending.schema.org/Place")]
    public class Place : Core.Place
    {
        /// <summary>
        /// Represents a relationship between two geometries (or the places 
        /// they represent), relating a containing geometry to a contained geometry.
        /// </summary>
        /// <remarks>
        /// "a contains b iff no points of b lie in the exterior of a, and at
        /// least one point of the interior of b lies in the interior of a". As
        /// defined in DE-9IM. See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyContains</example>
        [DataMember(Name = "geospatiallyContains")]
        public GeospatialGeometryOrPlace GeospatiallyContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places 
        /// they represent), relating a geometry to another that covers it.
        /// </summary>
        /// <remarks>
        /// As defined in DE-9IM. See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyCoveredBy</example>
        [DataMember(Name = "geospatiallyCoveredBy")]
        public GeospatialGeometryOrPlace GeospatiallyCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places 
        /// they represent), relating a covering geometry to a covered geometry.
        /// </summary>
        /// <remarks>
        /// "Every point of b is a point of (the interior or boundary of) a".
        /// As defined in DE-9IM. See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyCovers</example>
        [DataMember(Name = "geospatiallyCovers")]
        public GeospatialGeometryOrPlace GeospatiallyCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places 
        /// they represent), relating a geometry to another that crosses it.
        /// </summary>
        /// <remarks>
        /// "a crosses b: they have some but not all interior points in common,
        /// and the dimension of the intersection is less than that of at least
        /// one of them". As defined in DE-9IM. 
        /// See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyCrosses</example>
        [DataMember(Name = "geospatiallyCrosses")]
        public GeospatialGeometryOrPlace GeospatiallyCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places
        /// they represent) are topologically disjoint: they have no point in 
        /// common.
        /// </summary>
        /// <remarks>
        /// They form a set of disconnected geometries." (a symmetric 
        /// relationship). As defined in DE-9IM. 
        /// See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyDisjoint</example>
        [DataMember(Name = "geospatiallyDisjoint")]
        public GeospatialGeometryOrPlace GeospatiallyDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places
        /// they represent) are topologically equal.
        /// </summary>
        /// <remarks>
        /// "Two geometries are topologically equal if their interiors intersect
        /// and no part of the interior or boundary of one geometry intersects 
        /// the exterior of the other" (a symmetric relationship). As defined 
        /// in DE-9IM. 
        /// See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyEquals</example>
        [DataMember(Name = "geospatiallyEquals")]
        public GeospatialGeometryOrPlace GeospatiallyEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places
        /// they represent) have at least one point in common.
        /// </summary>
        /// <remarks>
        /// As defined in DE-9IM. See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyIntersects</example>
        [DataMember(Name = "geospatiallyIntersects")]
        public GeospatialGeometryOrPlace GeospatiallyIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places 
        /// they represent), relating a geometry to another that geospatially 
        /// overlaps it, i.e. they have some but not all points in common.
        /// </summary>
        /// <remarks>
        /// As defined in DE-9IM. See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyOverlaps</example>
        [DataMember(Name = "geospatiallyOverlaps")]
        public GeospatialGeometryOrPlace GeospatiallyOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places
        /// they represent) touch.
        /// </summary>
        /// <remarks>
        /// They have at least one boundary point in common, but no interior 
        /// points." (a symmetric relationship). As defined in DE-9IM. 
        /// See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyTouches</example>
        [DataMember(Name = "geospatiallyTouches")]
        public GeospatialGeometryOrPlace GeospatiallyTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places 
        /// they represent), relating a geometry to one that contains it, i.e. 
        /// it is inside (i.e. within) its interior.
        /// </summary>
        /// <remarks>
        /// As defined in DE-9IM. See https://en.wikipedia.org/wiki/DE-9IM.
        /// </remarks>
        /// <example>https://pending.schema.org/geospatiallyWithin</example>
        [DataMember(Name = "geospatiallyWithin")]
        public GeospatialGeometryOrPlace GeospatiallyWithin { get; set; }
    }
}
