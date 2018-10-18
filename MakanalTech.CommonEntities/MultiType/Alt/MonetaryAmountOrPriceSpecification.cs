using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// MonetaryAmountOrPriceSpecification MultiType accepts MonetaryAmount or PriceSpecification.
    /// </summary>
    [DataContract(Name = "MonetaryAmountOrPriceSpecification", Namespace = "CommonEntities.MultiType.Alt")]
    public class MonetaryAmountOrPriceSpecification
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// MonetaryAmountOrPriceSpecification as a MonetaryAmount.
        /// </summary>
        [DataMember(Name = "asMonetaryAmount")]
        public MonetaryAmount AsMonetaryAmount { get; set; }

        /// <summary>
        /// MonetaryAmountOrPriceSpecification as a PriceSpecification.
        /// </summary>
        [DataMember(Name = "asPriceSpecification")]
        public PriceSpecification AsPriceSpecification { get; set; }

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

        /// <summary>
        /// MonetaryAmountOrPriceSpecification.
        /// </summary>
        public MonetaryAmountOrPriceSpecification() { }
    }
}
