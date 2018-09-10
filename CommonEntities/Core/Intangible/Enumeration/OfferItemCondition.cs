using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// A list of possible conditions for the item.
    /// </summary>
    [DataContract(Name = "OfferItemCondition", Namespace = "https://schema.org/OfferItemCondition")]
    public enum OfferItemCondition
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Indicates that the item is damaged.
        /// </summary>
        /// <example>https://schema.org/DamagedCondition</example>
        [EnumMember(Value = "DamagedCondition")]
        DamagedCondition = 10,

        /// <summary>
        /// Indicates that the item is new.
        /// </summary>
        /// <example>https://schema.org/NewCondition</example>
        [EnumMember(Value = "NewCondition")]
        NewCondition = 20,

        /// <summary>
        /// Indicates that the item is refurbished.
        /// </summary>
        /// <example>https://schema.org/RefurbishedCondition</example>
        [EnumMember(Value = "RefurbishedCondition")]
        RefurbishedCondition = 30,

        /// <summary>
        /// Indicates that the item is used.
        /// </summary>
        /// <example>https://schema.org/UsedCondition</example>
        [EnumMember(Value = "UsedCondition")]
        UsedCondition = 40
    }
}
