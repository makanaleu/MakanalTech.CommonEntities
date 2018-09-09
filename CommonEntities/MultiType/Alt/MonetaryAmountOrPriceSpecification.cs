using CommonEntities.Core;
using CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// MonetaryAmountOrPriceSpecification MultiType accepts MonetaryAmount or PriceSpecification.
    /// </summary>
    [DataContract(Name = "MonetaryAmountOrPriceSpecification", Namespace = "CommonEntities.MultiType.Alt")]
    public class MonetaryAmountOrPriceSpecification
    {
        /// <summary>
        /// MonetaryAmountOrPriceSpecification as a MonetaryAmount.
        /// </summary>
        [DataMember(Name = "asMonetaryAmount")]
        public MonetaryAmount AsMonetaryAmount;

        /// <summary>
        /// MonetaryAmountOrPriceSpecification as a PriceSpecification.
        /// </summary>
        [DataMember(Name = "asPriceSpecification")]
        public PriceSpecification AsPriceSpecification;

        /// <summary>
        /// MonetaryAmountOrPriceSpecification as a MonetaryAmount.
        /// </summary>
        /// <param name="monetaryAmount">MonetaryAmountOrPriceSpecification as a MonetaryAmount.</param>
        public MonetaryAmountOrPriceSpecification(MonetaryAmount monetaryAmount)
        {
            AsMonetaryAmount = monetaryAmount;
        }

        /// <summary>
        /// MonetaryAmountOrPriceSpecification as a PriceSpecification.
        /// </summary>
        /// <param name="priceSpecification">MonetaryAmountOrPriceSpecification as a PriceSpecification.</param>
        public MonetaryAmountOrPriceSpecification(PriceSpecification priceSpecification)
        {
            AsPriceSpecification = priceSpecification;
        }
    }
}
