using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using CommonEntities.MultiType;
using CommonEntities.MultiType.Alt;
using CommonEntities.MultiType.Ref;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible
{
    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print 
    /// services, etc.
    /// </summary>
    [DataContract(Name = "Service", Namespace = "https://schema.org/Service")]
    public class Service : Thing
    {
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
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        /// <example>https://schema.org/audience</example>
        [DataMember(Name = "audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// A means of accessing the service (e.g. a phone bank, a web site, a 
        /// location, etc.).
        /// </summary>
        /// <example>https://schema.org/availableChannel</example>
        [DataMember(Name = "availableChannel")]
        public ServiceChannel AvailableChannel { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        /// <seealso cref="Awards"/>
        /// <example>https://schema.org/award</example>
        [DataMember(Name = "award")]
        public Text Award { get; set; }

        /// <summary>
        /// Awards won by or for this item.
        /// </summary>
        /// <seealso cref="Award"/>
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
        /// An entity that arranges for an exchange between a buyer and a seller.
        /// </summary>
        /// <remarks>
        ///  In most cases a broker never acquires or releases ownership of a 
        ///  product or service involved in an exchange. If it is not clear 
        ///  whether an entity is a broker, seller, or buyer, the latter two 
        ///  terms are preferred. 
        /// </remarks>
        /// <example>https://schema.org/broker</example>
        [DataMember(Name = "broker")]
        public OrganizationOrPerson Broker { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or
        /// Service.
        /// </summary>
        /// <example>https://schema.org/hasOfferCatalog</example>
        [DataMember(Name = "hasOfferCatalog")]
        public OfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        /// <example>https://schema.org/hoursAvailable</example>
        [DataMember(Name = "hoursAvailable")]
        public OpeningHoursSpecification HoursAvailable { get; set; }

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
        /// An associated logo.
        /// </summary>
        /// <example>https://schema.org/logo</example>
        [DataMember(Name = "logo")]
        public ImageObjectRef Logo { get; set; }

        /// <summary>
        /// An offer to provide this item—for example, an offer to sell a 
        /// product, rent the DVD of a movie, perform a service, or give away 
        /// tickets to an event.
        /// </summary>
        /// <example>https://schema.org/offers</example>
        [DataMember(Name = "offers")]
        public List<Offer> Offers { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the 
        /// goods producer.
        /// </summary>
        /// <remarks>
        /// Another party (a seller) may offer those services or goods on 
        /// behalf of the provider. A provider may also serve as the seller.
        /// </remarks>
        /// <example>https://schema.org/provider</example>
        [DataMember(Name = "provider")]
        public OrganizationOrPerson Provider { get; set; }

        /// <summary>
        /// Indicates the mobility of a provided service (e.g. 'static', 
        /// 'dynamic').
        /// </summary>
        /// <example>https://schema.org/providerMobility</example>
        [DataMember(Name = "providerMobility")]
        public Text ProviderMobility { get; set; }

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
        /// The tangible thing generated by the service, e.g. a passport, 
        /// permit, etc.
        /// </summary>
        /// <example>https://schema.org/serviceOutput</example>
        [DataMember(Name = "serviceOutput")]
        public Thing ServiceOutput { get; set; }

        /// <summary>
        /// The type of service being offered, e.g. veterans' benefits, 
        /// emergency relief, etc.
        /// </summary>
        /// <example>https://schema.org/serviceType</example>
        [DataMember(Name = "serviceType")]
        public Text ServiceType { get; set; }
    }
}
