using CommonEntities.Core.Intangible;
using CommonEntities.Core.Intangible.Enumeration;
using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using CommonEntities.MultiType.AltRef;
using CommonEntities.MultiType.Ref;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert
    /// ticket; the rental of a car; a haircut; or an episode of a TV show 
    /// streamed online.
    /// </summary>
    [DataContract(Name = "Product", Namespace = "https://schema.org/Product")]
    public class Product : Thing
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of
        /// the entitity, e.g. a product feature or another characteristic for 
        /// which there is no matching property in schema.org.
        /// </summary>
        /// <remarks>
        /// Note: Publishers should be aware that applications designed to use 
        /// specific schema.org properties (e.g. http://schema.org/width, 
        /// http://schema.org/color, http://schema.org/gtin13, ...) will 
        /// typically expect such data to be provided using those properties, 
        /// rather than using the generic property/value mechanism.
        /// </remarks>
        /// <example>https://schema.org/additionalProperty</example>
        [DataMember(Name = "additionalProperty")]
        public PropertyValue AdditionalProperty { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of
        /// the item.
        /// </summary>
        /// <example>https://schema.org/aggregateRating</example>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        /// <example>https://schema.org/audience</example>
        [DataMember(Name = "audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        /// <example>https://schema.org/award</example>
        [DataMember(Name = "award")]
        public Text Award { get; set; }

        /// <summary>
        /// A list of awards won by or for this item.
        /// </summary>
        /// <example>https://schema.org/awards</example>
        [DataMember(Name = "awards")]
        public List<Text> Awards { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s)
        /// maintained by an organization or business person.
        /// </summary>
        /// <example>https://schema.org/brand</example>
        [DataMember(Name = "brand")]
        public BrandOrOrganization Brand { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        /// <example>https://schema.org/color</example>
        [DataMember(Name = "color")]
        public Text Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        /// <example>https://schema.org/depth</example>
        [DataMember(Name = "depth")]
        public QuantitativeValueOrDistance Depth { get; set; }

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
        /// The height of the item.
        /// </summary>
        /// <example>https://schema.org/height</example>
        [DataMember(Name = "height")]
        public QuantitativeValueOrDistance Height { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which
        /// this product is an accessory or spare part.
        /// </summary>
        /// <example>https://schema.org/isAccessoryOrSparePartFor</example>
        [DataMember(Name = "isAccessoryOrSparePartFor")]
        public Product IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which
        /// this product is a consumable.
        /// </summary>
        /// <example>https://schema.org/isConsumableFor</example>
        [DataMember(Name = "isConsumableFor")]
        public Product IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        /// <example>https://schema.org/isRelatedTo</example>
        [DataMember(Name = "isRelatedTo")]
        public ProductOrService IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple 
        /// products).
        /// </summary>
        /// <example>https://schema.org/isSimilarTo</example>
        [DataMember(Name = "isSimilarTo")]
        public ProductOrService IsSimilarTo { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description
        /// of the condition of the product or service, or the products or 
        /// services included in the offer.
        /// </summary>
        /// <example>https://schema.org/itemCondition</example>
        [DataMember(Name = "itemCondition")]
        public OfferItemCondition? ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        /// <example>https://schema.org/logo</example>
        [DataMember(Name = "logo")]
        public ImageObjectRef Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        /// <example>https://schema.org/manufacturer</example>
        [DataMember(Name = "manufacturer")]
        public Organization Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton,
        /// paper.
        /// </summary>
        /// <example>https://schema.org/material</example>
        [DataMember(Name = "locationCreated")]
        public ProductOrTextRef Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a
        /// textual representation of the model identifier. The URL of the 
        /// ProductModel can be from an external source. It is recommended to 
        /// additionally provide strong product identifiers via the 
        /// gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        /// <example>https://schema.org/model</example>
        [DataMember(Name = "model")]
        public ProductModelOrText Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product 
        /// to which the offer refers.
        /// </summary>
        /// <example>https://schema.org/mpn</example>
        [DataMember(Name = "mpn")]
        public Text Mpn { get; set; }

        /// <summary>
        /// An offer to provide this item—for example, an offer to sell a 
        /// product, rent the DVD of a movie, perform a service, or give away 
        /// tickets to an event.
        /// </summary>
        /// <example>https://schema.org/offers</example>
        [DataMember(Name = "offers")]
        public List<Offer> Offers { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: meta 
        /// itemprop="productID" content="isbn:123-456-789".
        /// </summary>
        /// <example>https://schema.org/productID</example>
        [DataMember(Name = "productID")]
        public Text ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        /// <example>https://schema.org/productionDate</example>
        [DataMember(Name = "productionDate")]
        public Date ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        /// <example>https://schema.org/purchaseDate</example>
        [DataMember(Name = "purchaseDate")]
        public Date PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used 
        /// to distinguish the exact variant of a product.
        /// </summary>
        /// <example>https://schema.org/releaseDate</example>
        [DataMember(Name = "releaseDate")]
        public Date ReleaseDate { get; set; }

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
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier 
        /// for a product or service, or the product to which the offer refers. 
        /// </summary>
        /// <example>https://schema.org/sku</example>
        [DataMember(Name = "sku")]
        public Text Sku { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        /// <example>https://schema.org/weight</example>
        [DataMember(Name = "weight")]
        public QuantitativeValue Weight { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        /// <example>https://schema.org/width</example>
        [DataMember(Name = "width")]
        public QuantitativeValueOrDistance Width { get; set; }
    }
}
