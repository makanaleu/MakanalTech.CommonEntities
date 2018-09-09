using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount
    /// of money such as $50 USD, or a range as in describing a bank account 
    /// being suitable for a balance between £1,000 and £1,000,000 GBP, or the 
    /// value of a salary, etc. It is recommended to use PriceSpecification 
    /// Types to describe the price of an Offer, Invoice, etc.
    /// </summary>
    [DataContract(Name = "MonetaryAmount", Namespace = "https://schema.org/MonetaryAmount")]
    public class MonetaryAmount : Thing
    {
        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        /// <example>https://schema.org/maxValue</example>
        [DataMember(Name = "maxValue")]
        public Number MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        /// <example>https://schema.org/minValue</example>
        [DataMember(Name = "minValue")]
        public Number MinValue { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        /// <example>https://schema.org/validFrom</example>
        [DataMember(Name = "validFrom")]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of 
        /// an offer, salary period, or a period of opening hours.
        /// </summary>
        /// <example>https://schema.org/validThrough</example>
        [DataMember(Name = "validThrough")]
        public DateTime ValidThrough { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node.
        /// </summary>
        /// <example>https://schema.org/value</example>
        [DataMember(Name = "value")]
        public Number Value { get; set; }
    }
}
