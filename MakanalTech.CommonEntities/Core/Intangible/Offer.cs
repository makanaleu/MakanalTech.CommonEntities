using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType;
using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Combo;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DateTime = MakanalTech.CommonEntities.DataType.DateTime;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — 
    /// for example, an offer to sell tickets to an event, to rent the DVD of a
    /// movie, to stream a TV show over the internet, to repair a motorcycle, 
    /// or to loan a book.
    /// </summary>
    /// <remarks>
    /// For GTIN-related fields, see Check Digit calculator and validation 
    /// guide from GS1.
    /// See http://www.gs1.org/.
    /// </remarks>
    [DataContract(Name = "Organization", Namespace = "https://schema.org/Organization")]
    public class Offer : Thing
    {
        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        /// <example>https://schema.org/acceptedPaymentMethod</example>
        [DataMember(Name = "acceptedPaymentMethod")]
        public LoanOrCreditOrPaymentMethod AcceptedPaymentMethod { get; set; }

        /// <summary>
        /// An additional offer that can only be obtained in combination with 
        /// the first base offer (e.g. supplements and extensions that are 
        /// available for a surcharge).
        /// </summary>
        /// <example>https://schema.org/addOn</example>
        [DataMember(Name = "addOn")]
        public Offer AddOn { get; set; }

        /// <summary>
        /// The amount of time that is required between accepting the offer and
        /// the actual usage of the resource or service.
        /// </summary>
        /// <example>https://schema.org/advanceBookingRequirement</example>
        [DataMember(Name = "advanceBookingRequirement")]
        public QuantitativeValue AdvanceBookingRequirement { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of
        /// the item.
        /// </summary>
        /// <example>https://schema.org/aggregateRating</example>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided. 
        /// </summary>
        /// <example>https://schema.org/areaServed</example>
        [DataMember(Name = "areaServed")]
        public Area AreaServed { get; set; }

        /// <summary>
        /// The availability of this item—for example In stock, Out of stock, 
        /// Pre-order, etc. 
        /// </summary>
        /// <example>https://schema.org/availability</example>
        [DataMember(Name = "availability")]
        public ItemAvailability Availability { get; set; }

        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store 
        /// locations). 
        /// </summary>
        /// <example>https://schema.org/availableAtOrFrom</example>
        [DataMember(Name = "availableAtOrFrom")]
        public Place AvailableAtOrFrom { get; set; }

        /// <summary>
        /// The delivery method(s) available for this offer. 
        /// </summary>
        /// <example>https://schema.org/availableDeliveryMethod</example>
        [DataMember(Name = "availableDeliveryMethod")]
        public DeliveryMethod AvailableDeliveryMethod { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the 
        /// offer or component of a bundle (TypeAndQuantityNode). The default 
        /// is http://purl.org/goodrelations/v1#Sell. 
        /// </summary>
        /// <example>https://schema.org/businessFunction</example>
        [DataMember(Name = "businessFunction")]
        public BusinessFunction BusinessFunction { get; set; }

        /// <summary>
        /// The typical delay between the receipt of the order and the goods
        /// either leaving the warehouse or being prepared for pickup, in case
        /// the delivery method is on site pickup. 
        /// </summary>
        /// <example>https://schema.org/deliveryLeadTime</example>
        [DataMember(Name = "deliveryLeadTime")]
        public QuantitativeValue DeliveryLeadTime { get; set; }

        /// <summary>
        /// The type(s) of customers for which the given offer is valid. 
        /// </summary>
        /// <example>https://schema.org/eligibleCustomerType</example>
        [DataMember(Name = "eligibleCustomerType")]
        public BusinessEntityType EligibleCustomerType { get; set; }

        /// <summary>
        /// The duration for which the given offer is valid. 
        /// </summary>
        /// <example>https://schema.org/eligibleDuration</example>
        [DataMember(Name = "eligibleDuration")]
        public QuantitativeValue EligibleDuration { get; set; }

        /// <summary>
        /// The interval and unit of measurement of ordering quantities for 
        /// which the offer or price specification is valid.
        /// </summary>
        /// <remarks>
        /// This allows e.g. specifying that a certain freight charge is valid
        /// only for a certain quantity.
        /// </remarks>
        /// <example>https://schema.org/eligibleQuantity</example>
        [DataMember(Name = "eligibleQuantity")]
        public QuantitativeValue EligibleQuantity { get; set; }

        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or 
        /// price specification is valid, e.g. for indicating a minimal 
        /// purchasing volume, to express free shipping above a certain order 
        /// volume, or to limit the acceptance of credit cards to purchases to 
        /// a certain  minimal amount.
        /// </summary>
        /// <example>https://schema.org/eligibleTransactionVolume</example>
        [DataMember(Name = "eligibleTransactionVolume")]
        public PriceSpecification EligibleTransactionVolume { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer 
        /// refers.
        /// </summary>
        /// <remarks>
        /// The GTIN-12 is the 12-digit GS1 Identification Key composed of a 
        /// U.P.C. Company Prefix, Item Reference, and Check Digit used to 
        /// identify trade items.
        /// See http://www.gs1.org/barcodes/technical/idkeys/gtin.
        /// </remarks>
        /// <example>https://schema.org/gtin12</example>
        [DataMember(Name = "gtin12")]
        public Text Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer 
        /// refers.
        /// </summary>
        /// <remarks>
        /// This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 
        /// 12-digit UPC codes can be converted into a GTIN-13 code by simply 
        /// adding a preceeding zero.
        /// See http://www.gs1.org/barcodes/technical/idkeys/gtin.
        /// </remarks>
        /// <example>https://schema.org/gtin13</example>
        [DataMember(Name = "gtin13")]
        public Text Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer
        /// refers.
        /// </summary>
        /// <remarks>
        /// See http://www.gs1.org/barcodes/technical/idkeys/gtin.
        /// </remarks>
        /// <example>https://schema.org/gtin14</example>
        [DataMember(Name = "gtin14")]
        public Text Gtin14 { get; set; }

        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer 
        /// refers. This code is also known as EAN/UCC-8 or 8-digit EAN.
        /// </summary>
        /// <remarks>
        /// See http://www.gs1.org/barcodes/technical/idkeys/gtin.
        /// </remarks>
        /// <example>https://schema.org/gtin8</example>
        [DataMember(Name = "gtin8")]
        public Text Gtin8 { get; set; }

        /// <summary>
        /// This links to a node or nodes indicating the exact quantity of the
        /// products included in the offer.
        /// </summary>
        /// <example>https://schema.org/includesObject</example>
        [DataMember(Name = "includesObject")]
        public TypeAndQuantityNode IncludesObject { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place,
        /// or the GeoShape for the geo-political region(s) for which the offer
        /// or delivery charge specification is not valid, e.g. a region where 
        /// the transaction is not allowed.
        /// </summary>
        /// <seealso cref="Pending.Intangible.Offer.EligibleRegion"/>
        /// <example>https://schema.org/ineligibleRegion</example>
        [DataMember(Name = "ineligibleRegion")]
        public GeoShapePlaceOrText IneligibleRegion { get; set; }

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        /// <example>https://schema.org/inventoryLevel</example>
        [DataMember(Name = "inventoryLevel")]
        public QuantitativeValue InventoryLevel { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description
        /// of the condition of the product or service, or the products or 
        /// services included in the offer.
        /// </summary>
        /// <example>https://schema.org/itemCondition</example>
        [DataMember(Name = "itemCondition")]
        public OfferItemCondition ItemCondition { get; set; }

        /// <summary>
        /// The item being offered.
        /// </summary>
        /// <example>https://schema.org/itemOffered</example>
        [DataMember(Name = "itemOffered")]
        public ProductOrService ItemOffered { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product 
        /// to which the offer refers.
        /// </summary>
        /// <example>https://schema.org/mpn</example>
        [DataMember(Name = "mpn")]
        public Text Mpn { get; set; }

        /// <summary>
        /// A pointer to the organization or person making the offer.
        /// </summary>
        /// <seealso cref="Organization.MakesOffer"/>
        /// <seealso cref="Person.MakesOffer"/>
        /// <example>https://schema.org/offeredBy</example>
        [DataMember(Name = "offeredBy")]
        public OrganizationOrPerson OfferedBy { get; set; }

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
        /// One or more detailed price specifications, indicating the unit 
        /// price and delivery or payment charges.
        /// </summary>
        /// <example>https://schema.org/priceSpecification</example>
        [DataMember(Name = "priceSpecification")]
        public PriceSpecification PriceSpecification { get; set; }

        /// <summary>
        /// The date after which the price is no longer available.
        /// </summary>
        /// <example>https://schema.org/priceValidUntil</example>
        [DataMember(Name = "priceValidUntil")]
        public Date PriceValidUntil { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        /// <seealso cref="Reviews"/>
        /// <example>https://schema.org/review</example>
        [DataMember(Name = "review")]
        public Review Review { get; set; }

        /// <summary>
        /// A list of reviews of the item.
        /// </summary>
        /// <seealso cref="Review"/>
        /// <example>https://schema.org/reviews</example>
        [DataMember(Name = "reviews")]
        public List<Review> Reviews { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the 
        /// services / goods. A seller may also be a provider.
        /// </summary>
        /// <example>https://schema.org/seller</example>
        [DataMember(Name = "seller")]
        public OrganizationOrPerson Seller { get; set; }

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular 
        /// product. 
        /// </summary>
        /// <remarks>
        /// When attached to an offer, it is a shortcut for the serial number 
        /// of the product included in the offer.
        /// </remarks>
        /// <example>https://schema.org/serialNumber</example>
        [DataMember(Name = "serialNumber")]
        public Text SerialNumber { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier
        /// for a product or service, or the product to which the offer refers. 
        /// </summary>
        /// <example>https://schema.org/sku</example>
        [DataMember(Name = "sku")]
        public Text Sku { get; set; }

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
        /// The warranty promise(s) included in the offer.
        /// </summary>
        /// <example>https://schema.org/warranty</example>
        [DataMember(Name = "warranty")]
        public WarrantyPromise Warranty { get; set; }
    }
}
