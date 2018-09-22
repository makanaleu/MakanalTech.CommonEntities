using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
    [DataContract(Name = "Rating", Namespace = "https://schema.org/Rating")]
    public class Rating : Thing
    {
        /// <summary>
        /// The author of this content or rating.
        /// </summary>
        /// <remarks>
        /// Please note that author is special in that HTML 5 provides a special
        /// mechanism for indicating authorship via the rel tag. That is 
        /// equivalent to this and may be used interchangeably.
        /// </remarks>
        /// <example>https://schema.org/author</example>
        [DataMember(Name = "author")]
        public OrganizationOrPerson Author { get; set; }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is 
        /// omitted, 5 is assumed.
        /// </summary>
        /// <example>https://schema.org/bestRating</example>
        [DataMember(Name = "bestRating")]
        public Number BestRating { get; set; }

        /// <summary>
        /// The rating for the content.
        /// </summary>
        /// <example>https://schema.org/ratingValue</example>
        [DataMember(Name = "ratingValue")]
        public Number RatingValue { get; set; }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is 
        /// omitted, 1 is assumed.
        /// </summary>
        /// <example>https://schema.org/worstRating</example>
        [DataMember(Name = "worstRating")]
        public Number WorstRating { get; set; }
    }
}
