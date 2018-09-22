using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.Thing.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Thing", Namespace = "https://pending.schema.org/Thing")]
    public class Thing : Core.Thing
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
