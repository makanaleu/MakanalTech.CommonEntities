using CommonEntities.Core.Intangible.Enumeration;
using CommonEntities.DataType;
using System.Runtime.Serialization;
using System;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ItemListOrderTypeOrText MultiType accepts either an ItemListOrderType or string.
    /// </summary>
    /// <example>https://schema.org/itemListOrder</example>
    [DataContract(Name = "ItemListOrderTypeOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class ItemListOrderTypeOrText : Text
    {
        /// <summary>
        /// ItemListOrderTypeOrText as an ItemListOrderType.
        /// </summary>
        [DataMember(Name = "asItemListOrderType")]
        public ItemListOrderType AsItemListOrderType;

        /// <summary>
        /// ItemListOrderTypeOrText as an ItemListOrderType.
        /// </summary>
        /// <param name="itemListOrderType">ItemListOrderTypeOrText as an ItemListOrderType.</param>
        public ItemListOrderTypeOrText(ItemListOrderType itemListOrderType) 
            : base(Enum.GetName(typeof(ItemListOrderType), itemListOrderType))
        {
            AsItemListOrderType = itemListOrderType;
        }

        /// <summary>
        /// ItemListOrderTypeOrText as a string.
        /// </summary>
        /// <param name="text">ItemListOrderTypeOrText as a string.</param>
        public ItemListOrderTypeOrText(string text) : base(text) { }

        /// <summary>
        /// ItemListOrderTypeOrText.
        /// </summary>
        public ItemListOrderTypeOrText() { }
    }
}
