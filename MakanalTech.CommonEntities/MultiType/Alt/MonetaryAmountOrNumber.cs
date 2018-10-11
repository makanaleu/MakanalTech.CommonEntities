using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// MonetaryAmountOrNumber MultiType accepts a MonetaryAmount or Number.
    /// </summary>
    /// <example>https://schema.org/amount</example>
    [DataContract(Name = "MonetaryAmountOrNumber", Namespace = "CommonEntities.MultiType.Alt")]
    public class MonetaryAmountOrNumber : Number
    {
        /// <summary>
        /// MonetaryAmountOrNumber as a MonetaryAmount.
        /// </summary>
        public MonetaryAmount AsMonetaryAmount { get; set; }

        /// <summary>
        /// MonetaryAmountOrNumber as a MonetaryAmount.
        /// </summary>
        /// <param name="monetaryAmount">MonetaryAmountOrNumber as a MonetaryAmount.</param>
        public MonetaryAmountOrNumber(MonetaryAmount monetaryAmount) 
            : base(monetaryAmount.Value.AsText)
        {
            AsMonetaryAmount = monetaryAmount;
        }

        /// <summary>
        /// MonetaryAmountOrNumber as a Number.
        /// </summary>
        /// <param name="number">MonetaryAmountOrNumber as a Number.</param>
        public MonetaryAmountOrNumber(Number number) : base(number) { }

        /// <summary>
        /// MonetaryAmountOrNumber.
        /// </summary>
        public MonetaryAmountOrNumber() : base() { }
    }
}
