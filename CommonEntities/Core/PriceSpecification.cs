using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using System.Runtime.Serialization;
using Boolean = CommonEntities.DataType.Boolean;
using DateTime = CommonEntities.DataType.DateTime;

namespace CommonEntities.Core
{
    /// <summary>
    /// A structured value representing a price or price range. Typically, only 
    /// the subclasses of this type are used for markup. It is recommended to use
    /// MonetaryAmount to describe independent amounts of money such as a salary,
    /// credit card limits, etc.
    /// </summary>
    [DataContract(Name = "PriceSpecification", Namespace = "https://schema.org/PriceSpecification")]
    public class PriceSpecification : Thing
    {
        /// <summary>
        /// The interval and unit of measurement of ordering quantities for 
        /// which the offer or price specification is valid. This allows e.g. 
        /// specifying that a certain freight charge is valid only for a certain
        /// quantity.
        /// </summary>
        /// <example>https://schema.org/eligibleQuantity</example>
        [DataMember(Name = "eligibleQuantity")]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or 
        /// price specification is valid, e.g. for indicating a minimal 
        /// purchasing volume, to express free shipping above a certain order 
        /// volume, or to limit the acceptance of credit cards to purchases to 
        /// a certain minimal amount.
        /// </summary>
        /// <example>https://schema.org/eligibleTransactionVolume</example>
        [DataMember(Name = "eligibleTransactionVolume")]
        public PriceSpecification EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The highest price if the price is a range.
        /// </summary>
        /// <example>https://schema.org/maxPrice</example>
        [DataMember(Name = "maxPrice")]
        public Number MaxPrice { get; set; }

        /// <summary>
        /// The lowest price if the price is a range.
        /// </summary>
        /// <example>https://schema.org/minPrice</example>
        [DataMember(Name = "minPrice")]
        public Number MinPrice { get; set; }

        /// <summary>
        /// The offer price of a product, or of a price component when attached
        /// to PriceSpecification and its subtypes.
        /// </summary>
        /// <remarks>Usage guidelines: https://schema.org/price </remarks>
        /// <example>https://schema.org/price</example>
        [DataMember(Name = "price")]
        public Number Price { get; set; }

        /// <summary>
        /// The currency of the price, or a price component when attached to 
        /// PriceSpecification and its subtypes.
        /// </summary>
        /// <remarks>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker 
        /// symbol for cryptocurrencies e.g. "BTC"; well known names for Local 
        /// Exchange Tradings Systems (LETS) and other currency types e.g. 
        /// "Ithaca HOUR".
        /// </remarks>
        /// <example>https://schema.org/priceCurrency</example>
        [DataMember(Name = "priceCurrency")]
        public Text PriceCurrency { get; set; }

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
        /// Specifies whether the applicable value-added tax (VAT) is included 
        /// in the price specification or not.
        /// </summary>
        /// <example>https://schema.org/valueAddedTaxIncluded</example>
        [DataMember(Name = "valueAddedTaxIncluded")]
        public Boolean ValueAddedTaxIncluded { get; set; }
    }
}
