using MakanalTech.CommonEntities.MultiType.Combo;
using System.Runtime.Serialization;
using DateTime = MakanalTech.CommonEntities.DataType.DateTime;

namespace MakanalTech.CommonEntities.Pending.Intangible
{
    /// <summary>
    /// Pending Extension of Core.Intangible.Offer.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Offer", Namespace = "https://pending.schema.org/Offer")]
    public class Offer : Core.Intangible.Offer
    {
        /// <summary>
        /// The end of the availability of the product or service included in 
        /// the offer.
        /// </summary>
        /// <example>https://pending.schema.org/availabilityEnds</example>
        [DataMember(Name = "availabilityEnds")]
        public DateTime AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included
        /// in the offer.
        /// </summary>
        /// <example>https://pending.schema.org/availabilityStarts</example>
        [DataMember(Name = "availabilityStarts")]
        public DateTime AvailabilityStarts { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to 
        /// informally indicate 
        /// a category hierarchy.
        /// </summary>
        /// <example>https://pending.schema.org/category</example>
        [DataMember(Name = "category")]
        public PhysicalActivityCategoryThingOrText Category { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, 
        /// or the GeoShape for the geo-political region(s) for which the 
        /// offer or delivery charge specification is valid.
        /// </summary>
        /// <example>https://pending.schema.org/eligibleRegion</example>
        [DataMember(Name = "eligibleRegion")]
        public GeoShapePlaceOrText EligibleRegion { get; set; }
    }
}
