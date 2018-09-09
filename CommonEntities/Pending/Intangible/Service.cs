using CommonEntities.MultiType;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.Pending.Intangible
{
    /// <summary>
    /// Pending Extension of Core.Intangible.Service.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Service", Namespace = "https://pending.schema.org/Service")]
    public class Service : Core.Intangible.Service
    {
        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to 
        /// informally indicate a category hierarchy.
        /// </summary>
        /// <example>https://pending.schema.org/category</example>
        [DataMember(Name = "category")]
        public Category Category { get; set; }

        /// <summary>
        /// Human-readable terms of service documentation.
        /// </summary>
        /// <example>https://pending.schema.org/termsOfService</example>
        [DataMember(Name = "termsOfService")]
        public TextRef TermsOfService { get; set; }
    }
}
