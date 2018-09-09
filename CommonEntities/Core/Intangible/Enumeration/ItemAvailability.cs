using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// A list of possible product availability options.
    /// </summary>
    [DataContract(Name = "ItemAvailability", Namespace = "https://schema.org/ItemAvailability")]
    public enum ItemAvailability
    {
        /// <summary>
        /// Indicates that the item has been discontinued.
        /// </summary>
        /// <example>https://schema.org/Discontinued</example>
        [EnumMember(Value = "Discontinued")]
        Discontinued = 10,

        /// <summary>
        /// Indicates that the item is in stock.
        /// </summary>
        /// <example>https://schema.org/InStock</example>
        [EnumMember(Value = "InStock")]
        InStock = 20,

        /// <summary>
        /// Indicates that the item is available only at physical locations.
        /// </summary>
        /// <example>https://schema.org/InStoreOnly</example>
        [EnumMember(Value = "InStoreOnly")]
        InStoreOnly = 30,

        /// <summary>
        /// Indicates that the item has limited availability.
        /// </summary>
        /// <example>https://schema.org/LimitedAvailability</example>
        [EnumMember(Value = "LimitedAvailability")]
        LimitedAvailability = 40,

        /// <summary>
        /// Indicates that the item is available only online.
        /// </summary>
        /// <example>https://schema.org/OnlineOnly</example>
        [EnumMember(Value = "OnlineOnly")]
        OnlineOnly = 50,

        /// <summary>
        /// Indicates that the item is out of stock.
        /// </summary>
        /// <example>https://schema.org/OutOfStock</example>
        [EnumMember(Value = "OutOfStock")]
        OutOfStock = 60,

        /// <summary>
        /// Indicates that the item is available for pre-order, but will be 
        /// delivered when generally available.
        /// </summary>
        /// <example>https://schema.org/PreOrder</example>
        [EnumMember(Value = "PreOrder")]
        PreOrder = 70,

        /// <summary>
        /// Indicates that the item is available for ordering and delivery 
        /// before general availability.
        /// </summary>
        /// <example>https://schema.org/PreSale</example>
        [EnumMember(Value = "PreSale")]
        PreSale = 80,

        /// <summary>
        /// Indicates that the item has sold out.
        /// </summary>
        /// <example>https://schema.org/SoldOut</example>
        [EnumMember(Value = "SoldOut")]
        SoldOut = 90
    }
}
