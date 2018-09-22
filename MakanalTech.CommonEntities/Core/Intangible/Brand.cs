using MakanalTech.CommonEntities.MultiType.Ref;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// A brand is a name used by an organization or business person for 
    /// labeling a product,
    /// product group, or similar.
    /// </summary>
    [DataContract(Name = "Brand", Namespace = "https://schema.org/Brand")]
    public class Brand : Thing
    {
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, 
        /// of the item.
        /// </summary>
        /// <example>https://schema.org/aggregateRating</example>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        /// <example>https://schema.org/logo</example>
        [DataMember(Name = "logo")]
        public ImageObjectRef Logo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        /// <seealso cref="Reviews"/>
        /// <example>https://schema.org/review</example>
        [DataMember(Name = "review")]
        public Review Review { get; set; }

        /// <summary>
        /// A list of reviews of the item.
        /// </summary>
        /// <seealso cref="Review"/>
        /// <example>https://schema.org/reviews</example>
        [DataMember(Name = "reviews")]
        public List<Review> Reviews { get; set; }
    }
}
