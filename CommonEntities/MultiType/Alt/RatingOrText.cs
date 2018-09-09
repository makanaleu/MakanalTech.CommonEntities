using CommonEntities.Core.Intangible;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// RatingOrText MultiType accepts either Rating or Text (string).
    /// </summary>
    [DataContract(Name = "RatingOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class RatingOrText : Text
    {
        /// <summary>
        /// RatingOrText as a Rating.
        /// </summary>
        [DataMember(Name = "asRating")]
        public Rating AsRating;

        /// <summary>
        /// RatingOrText as a Rating.
        /// </summary>
        /// <param name="rating">RatingOrText as a Rating.</param>
        public RatingOrText(Rating rating) : base(rating.RatingValue.AsText)
        {
            AsRating = rating;
        }

        /// <summary>
        /// RatingOrText as a Text (string).
        /// </summary>
        /// <param name="text">RatingOrText as a Text (string).</param>
        public RatingOrText(string text) : base(text)
        {
        }
    }
}
