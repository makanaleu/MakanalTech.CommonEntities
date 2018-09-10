using CommonEntities.Core.Intangible;
using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using CommonEntities.MultiType;
using CommonEntities.MultiType.Alt;
using CommonEntities.MultiType.Combo;
using CommonEntities.MultiType.Ref;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DateTime = CommonEntities.DataType.DateTime;

namespace CommonEntities.Core
{
    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    [DataContract(Name = "Organization", Namespace = "https://schema.org/Organization")]
    public class Organization : Thing
    {
        /// <summary>
        /// Physical address of the item.
        /// </summary>
        /// <example>https://schema.org/address</example>
        [DataMember(Name = "address")]
        public PostalAddress Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of
        /// the item.
        /// </summary>
        /// <example>https://schema.org/aggregateRatings</example>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        /// <seealso cref="Person.AlumniOf"/>
        /// <example>https://schema.org/alumni</example>
        [DataMember(Name = "alumni")]
        public Person Alumni { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        /// <example>https://schema.org/areaServed</example>
        [DataMember(Name = "areaServed")]
        public Area AreaServed { get; set; }

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
        /// A contact point for a person or organization.
        /// </summary>
        /// <seealso cref="ContactPoints"/>
        /// <example>https://schema.org/contactPoint</example>
        [DataMember(Name = "contactPoint")]
        public ContactPoint ContactPoint { get; set; }

        /// <summary>
        /// A list of contact points for a person or organization.
        /// </summary>
        /// <seealso cref="ContactPoint"/>
        /// <example>https://schema.org/contactPoints</example>
        [DataMember(Name = "contactPoints")]
        public List<ContactPoint> ContactPoints { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that 
        /// organization, also described as an organization (allowing different
        /// urls, logos, opening hours). For example: a store with a pharmacy,
        /// or a bakery with a cafe.
        /// </summary>
        /// <example>https://schema.org/department</example>
        [DataMember(Name = "department")]
        public Organization Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        /// <example>https://schema.org/dissolutionDate</example>
        [DataMember(Name = "dissolutionDate")]
        public Date DissolutionDate { get; set; }

        /// <summary>
        /// The Dun &amp; Bradstreet DUNS number for identifying an organization or
        /// business person.
        /// </summary>
        /// <example>https://schema.org/duns</example>
        [DataMember(Name = "duns")]
        public Text Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        /// <example>https://schema.org/email</example>
        [DataMember(Name = "email")]
        public Text Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        /// <seealso cref="Employees"/>
        /// <example>https://schema.org/employee</example>
        [DataMember(Name = "employee")]
        public Person Employee { get; set; }

        /// <summary>
        /// List of people working for this organization.
        /// </summary>
        /// <seealso cref="Employee"/>
        /// <example>https://schema.org/employees</example>
        [DataMember(Name = "employees")]
        public List<Person> Employees { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or
        /// action.
        /// </summary>
        /// <seealso cref="Events"/>
        /// <example>https://schema.org/event</example>
        [DataMember(Name = "event")]
        public Event Event { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or
        /// action.
        /// </summary>
        /// <seealso cref="Event"/>
        /// <example>https://schema.org/events</example>
        [DataMember(Name = "events")]
        public List<Event> Events { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        /// <example>https://schema.org/faxNumber</example>
        [DataMember(Name = "faxNumber")]
        public Text FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        /// <seealso cref="Founders"/>
        /// <example>https://schema.org/founder</example>
        [DataMember(Name = "founder")]
        public Person Founder { get; set; }

        /// <summary>
        /// A list of people who founded this organization.
        /// </summary>
        /// <seealso cref="Founder"/>
        /// <example>https://schema.org/founders</example>
        [DataMember(Name = "founders")]
        public List<Person> Founders { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        /// <example>https://schema.org/foundingDate</example>
        [DataMember(Name = "foundingDate")]
        public Date FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        /// <example>https://schema.org/foundingLocation</example>
        [DataMember(Name = "foundingLocation")]
        public Place FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through
        /// some kind of financial contribution.
        /// </summary>
        /// <example>https://schema.org/funder</example>
        [DataMember(Name = "funder")]
        public OrganizationOrPerson Funder { get; set; }

        /// <summary>
        /// The Global Location Number (GLN, sometimes also referred to as 
        /// International Location Number or ILN) of the respective organization,
        /// person, or place.
        /// </summary>
        /// <remarks>
        /// The GLN is a 13-digit number used to identify parties and physical 
        /// locations.
        /// See http://www.gs1.org/gln
        /// </remarks>
        /// <example>https://schema.org/globalLocationNumber</example>
        [DataMember(Name = "globalLocationNumber")]
        public Text GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or
        /// Service.
        /// </summary>
        /// <example>https://schema.org/hasOfferCatalog</example>
        [DataMember(Name = "hasOfferCatalog")]
        public OfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        /// <example>https://schema.org/hasPOS</example>
        [DataMember(Name = "hasPOS")]
        public Place HasPOS { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All 
        /// Economic Activities (ISIC), Revision 4 code for a particular 
        /// organization, business person, or place.
        /// </summary>
        /// <example>https://schema.org/isicV4</example>
        [DataMember(Name = "isicV4")]
        public Text IsICv4 { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company
        /// name.
        /// </summary>
        /// <example>https://schema.org/legalName</example>
        [DataMember(Name = "legalName")]
        public Text LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity
        /// as defined in ISO 17442.
        /// </summary>
        /// <example>https://schema.org/leiCode</example>
        [DataMember(Name = "leiCode")]
        public Text LEICode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an 
        /// organization is located, or where an action 
        /// takes place.
        /// </summary>
        /// <example>https://schema.org/location</example>
        [DataMember(Name = "location")]
        public PlacePostalAddressOrText Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        /// <example>https://schema.org/logo</example>
        [DataMember(Name = "logo")]
        public ImageObjectRef Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or 
        /// person.
        /// </summary>
        /// <seealso cref="Offer.OfferedBy"/>
        /// <example>https://schema.org/makesOffer</example>
        [DataMember(Name = "makesOffer")]
        public Offer MakesOffer { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. 
        /// </summary>
        /// <remarks>
        /// Organizations can be members of organizations; ProgramMembership is
        /// typically for individuals
        /// </remarks>
        /// <seealso cref="Members"/>
        /// <seealso cref="MemberOf"/>
        /// <example>https://schema.org/member</example>
        [DataMember(Name = "member")]
        public OrganizationOrPerson Member { get; set; }

        /// <summary>
        /// A list of members of an Organization or a ProgramMembership. 
        /// </summary>
        /// <remarks>
        /// Organizations can be members of organizations; ProgramMembership is
        /// typically for individuals
        /// </remarks>
        /// <seealso cref="Member"/>
        /// <example>https://schema.org/members</example>
        [DataMember(Name = "members")]
        public List<OrganizationOrPerson> Members { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or 
        /// Organization belongs.
        /// </summary>
        /// <seealso cref="Member"/>
        /// <example>https://schema.org/memberOf</example>
        [DataMember(Name = "memberOf")]
        public OrganizationOrProgramMembership MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for 
        /// a particular organization or business person.
        /// </summary>
        /// <example>https://schema.org/naics</example>
        [DataMember(Name = "naics")]
        public Text NAICS { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        /// <example>https://schema.org/numberOfEmployees</example>
        [DataMember(Name = "numberOfEmployees")]
        public QuantitativeValue NumberOfEmployees { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        /// <example>https://schema.org/owns</example>
        [DataMember(Name = "owns")]
        public OwnershipInfoOrProduct Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a subOrganization
        /// of, if any.
        /// </summary>
        /// <seealso cref="SubOrganization"/>
        /// <example>https://schema.org/parentOrganization</example>
        [DataMember(Name = "parentOrganization")]
        public Organization ParentOrganization { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via URL) a 
        /// document describing the editorial principles of an Organization (or
        /// individual e.g. a Person writing a blog) that relate to their 
        /// activities as a publisher, e.g. ethics or diversity policies.
        /// </summary>
        /// <remarks>
        /// When applied to a CreativeWork (e.g. NewsArticle) the principles 
        /// are those of the party primarily responsible for the creation of 
        /// the CreativeWork.
        /// 
        /// While such policies are most typically expressed in natural language,
        /// sometimes related information (e.g. indicating a funder) can be 
        /// expressed using schema.org terminology.
        /// </remarks>
        /// <example>https://schema.org/publishingPrinciples</example>
        [DataMember(Name = "publishingPrinciples")]
        public CreativeWorkRef PublishingPrinciples { get; set; }

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
        /// A pointer to products or services sought by the organization or 
        /// person (demand).
        /// </summary>
        /// <example>https://schema.org/seeks</example>
        [DataMember(Name = "seeks")]
        public Demand Seeks { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, 
        /// promise, or financial contribution. e.g. a sponsor of a Medical 
        /// Study or a corporate sponsor of an event.
        /// </summary>
        /// <example>https://schema.org/sponsor</example>
        [DataMember(Name = "sponsor")]
        public OrganizationOrPerson Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes 
        /// the second, e.g., as a subsidiary. See also: the more specific 
        /// 'department' property.
        /// </summary>
        /// <seealso cref="ParentOrganization"/>
        /// <seealso cref="Department"/>
        /// <example>https://schema.org/subOrganization</example>
        [DataMember(Name = "subOrganization")]
        public Organization SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in 
        /// the US or the CIF/NIF in Spain.
        /// </summary>
        /// <example>https://schema.org/taxID</example>
        [DataMember(Name = "taxID")]
        public Text TaxId { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        /// <example>https://schema.org/telephone</example>
        [DataMember(Name = "telephone")]
        public Text Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        /// <example>https://schema.org/vatID</example>
        [DataMember(Name = "vatID")]
        public Text VATId { get; set; }
    }
}
