using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.Review.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Review", Namespace = "https://pending.schema.org/Review")]
    public class Review : Core.Review
    {
        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the 
        /// itemReviewed.
        /// </summary>
        /// <example>https://pending.schema.org/reviewAspect</example>
        [DataMember(Name = "reviewAspect")]
        public Text ReviewAspect { get; set; }
    }
}
