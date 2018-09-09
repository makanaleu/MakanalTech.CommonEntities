using CommonEntities.MultiType.Combo;
using System.Runtime.Serialization;

namespace CommonEntities.Pending
{
    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket;
    /// the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Product", Namespace = "https://pending.schema.org/Product")]
    public class Product : Core.Product
    {
        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to
        /// informally indicate a category hierarchy.
        /// </summary>
        /// <example>https://pending.schema.org/category</example>
        [DataMember(Name = "category")]
        public PhysicalActivityCategoryThingOrText Category { get; set; }
    }
}
