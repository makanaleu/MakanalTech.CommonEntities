using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    [DataContract(Name = "AggregateRating", Namespace = "https://schema.org/AggregateRating")]
    public class AggregateRating : Rating
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        /// <example>https://schema.org/itemReviewed</example>
        [DataMember(Name = "itemReviewed")]
        public Thing ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        /// <example>https://schema.org/ratingCount</example>
        [DataMember(Name = "ratingCount")]
        public int RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        /// <example>https://schema.org/reviewCount</example>
        [DataMember(Name = "reviewCount")]
        public int ReviewCount { get; set; }
    }
}
