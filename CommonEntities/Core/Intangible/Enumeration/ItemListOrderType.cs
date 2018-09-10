using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered 
    /// ItemList is organized.
    /// </summary>
    [DataContract(Name = "ItemListOrderType", Namespace = "https://schema.org/ItemListOrderType")]
    public enum ItemListOrderType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// An ItemList ordered with lower values listed first.
        /// </summary>
        /// <example>https://schema.org/ItemListOrderAscending</example>
        [EnumMember(Value = "ItemListOrderAscending")]
        ItemListOrderAscending = 10,

        /// <summary>
        /// An ItemList ordered with higher values listed first.
        /// </summary>
        /// <example>https://schema.org/ItemListOrderDescending</example>
        [EnumMember(Value = "ItemListOrderDescending")]
        ItemListOrderDescending = 20,

        /// <summary>
        /// An ItemList ordered with no explicit order.
        /// </summary>
        /// <example>https://schema.org/ItemListUnordered</example>
        [EnumMember(Value = "ItemListUnordered")]
        ItemListUnordered = 30
    }
}
