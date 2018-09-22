using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    [DataContract(Name = "Review", Namespace = "https://schema.org/Review")]
    public class Review : CreativeWork
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        /// <example>https://schema.org/itemReviewed</example>
        [DataMember(Name = "itemReviewed")]
        public Thing ItemReviewed { get; set; }

        /// <summary>
        /// The actual body of the review.
        /// </summary>
        /// <example>https://schema.org/reviewBody</example>
        [DataMember(Name = "reviewBody")]
        public Text ReviewBody { get; set; }

        /// <summary>
        /// The rating given in this review.
        /// </summary>
        /// <remarks>
        /// Note that reviews can themselves be rated. The reviewRating applies
        /// to rating given by the review. The aggregateRating property applies
        /// to the review itself, as a creative work.
        /// </remarks>
        /// <example>https://schema.org/reviewRating</example>
        [DataMember(Name = "reviewRating")]
        public Rating ReviewRating { get; set; }
    }
}
