using CommonEntities.Core.Intangible;
using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using CommonEntities.MultiType.Ref;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract(Name = "Person", Namespace = "https://schema.org/Person")]
    public class Person : Thing
    {
        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        /// <example>https://schema.org/additionalName</example>
        [DataMember(Name = "additionalName")]
        public Text AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        /// <example>https://schema.org/address</example>
        [DataMember(Name = "address")]
        public PostalAddressOrText Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, 
        /// a school/university, a club, or a team.
        /// </summary>
        /// <example>https://schema.org/affiliation</example>
        [DataMember(Name = "affiliation")]
        public Organization Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        /// <example>https://schema.org/alumniOf</example>
        [DataMember(Name = "alumniOf")]
        public OrganizationOrEducationalOrganization AlumniOf { get; set; }

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
        /// Date of birth.
        /// </summary>
        /// <example>https://schema.org/birthDate</example>
        [DataMember(Name = "birthDate")]
        public Date BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        /// <example>https://schema.org/birthPlace</example>
        [DataMember(Name = "birthPlace")]
        public Place BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s)
        /// maintained by an organization or business person.
        /// </summary>
        /// <example>https://schema.org/brand</example>
        [DataMember(Name = "brand")]
        public BrandOrOrganization Brand { get; set; }

        /// <summary>
        /// A list of children of the person.
        /// </summary>
        /// <example>https://schema.org/children</example>
        [DataMember(Name = "children")]
        public List<Person> Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        /// <seealso cref="Colleagues"/>
        /// <example>https://schema.org/colleague</example>
        [DataMember(Name = "colleague")]
        public PersonRef Colleague { get; set; }

        /// <summary>
        /// A list of colleagues of the person.
        /// </summary>
        /// <seealso cref="Colleague"/>
        /// <example>https://schema.org/colleagues</example>
        [DataMember(Name = "colleagues")]
        public List<Person> Colleagues { get; set; }

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
        /// Date of death.
        /// </summary>
        /// <example>https://schema.org/deathDate</example>
        [DataMember(Name = "deathDate")]
        public Date DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        /// <example>https://schema.org/deathPlace</example>
        [DataMember(Name = "deathPlace")]
        public Place DeathPlace { get; set; }

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
        /// Family name.
        /// </summary>
        /// <example>https://schema.org/familyName</example>
        [DataMember(Name = "familyName")]
        public Text FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        /// <example>https://schema.org/faxNumber</example>
        [DataMember(Name = "faxNumber")]
        public Text FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        /// <example>https://schema.org/follows</example>
        [DataMember(Name = "follows")]
        public List<Person> Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through
        /// some kind of financial contribution.
        /// </summary>
        /// <example>https://schema.org/funder</example>
        [DataMember(Name = "funder")]
        public OrganizationOrPerson Funder { get; set; }

        /// <summary>
        /// Gender of the person. 
        /// </summary>
        /// <remarks>
        /// While http://schema.org/Male and http://schema.org/Female may be 
        /// used, text strings are also acceptable for people who do not 
        /// identify as a binary gender.
        /// </remarks>
        /// <example>https://schema.org/gender</example>
        [DataMember(Name = "gender")]
        public GenderTypeOrText Gender { get; set; }

        /// <summary>
        /// Given name.
        /// </summary>
        /// <example>https://schema.org/givenName</example>
        [DataMember(Name = "givenName")]
        public Text GivenName { get; set; }

        /// <summary>
        /// The Global Location Number (GLN, sometimes also referred to as 
        /// International Location Number or ILN) of the respective organization,
        /// person, or place.
        /// </summary>
        /// <remarks>
        /// The GLN is a 13-digit number used to identify parties and physical 
        /// locations. See http://www.gs1.org/gln
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
        /// The height of the item.
        /// </summary>
        /// <example>https://schema.org/height</example>
        [DataMember(Name = "height")]
        public QuantitativeValueOrDistance Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        /// <example>https://schema.org/homeLocation</example>
        [DataMember(Name = "homeLocation")]
        public ContactPointOrPlace HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        /// <example>https://schema.org/honorificPrefix</example>
        [DataMember(Name = "honorificPrefix")]
        public Text HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D./PhD/MSCSW.
        /// </summary>
        /// <example>https://schema.org/honorificSuffix</example>
        [DataMember(Name = "honorificSuffix")]
        public Text HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All 
        /// Economic Activities (ISIC), Revision 4 code for a particular 
        /// organization, business person, or place.
        /// </summary>
        /// <example>https://schema.org/isicV4</example>
        [DataMember(Name = "isicV4")]
        public Text IsICv4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        /// <example>https://schema.org/jobTitle</example>
        [DataMember(Name = "jobTitle")]
        public Text JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        /// <example>https://schema.org/knows</example>
        [DataMember(Name = "knows")]
        public List<Person> Knows { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or 
        /// person.
        /// </summary>
        /// <seealso cref="Offer.OfferedBy"/>
        /// <example>https://schema.org/makesOffer</example>
        [DataMember(Name = "makesOffer")]
        public Offer MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or 
        /// Organization belongs.
        /// </summary>
        /// <seealso cref="Organization.Member"/>
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
        /// Nationality of the person.
        /// </summary>
        /// <example>https://schema.org/nationality</example>
        [DataMember(Name = "nationality")]
        public Country Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by 
        /// subtracting assets from liabilities.
        /// </summary>
        /// <example>https://schema.org/netWorth</example>
        [DataMember(Name = "netWorth")]
        public MonetaryAmountOrPriceSpecification NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        /// <example>https://schema.org/owns</example>
        [DataMember(Name = "owns")]
        public OwnershipInfoOrProduct Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        /// <seealso cref="Parents"/>
        /// <example>https://schema.org/parent</example>
        [DataMember(Name = "parent")]
        public Person Parent { get; set; }

        /// <summary>
        /// A list of parents of this person.
        /// </summary>
        /// <seealso cref="Parent"/>
        /// <example>https://schema.org/parents</example>
        [DataMember(Name = "parents")]
        public List<Person> Parents { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        /// <example>https://schema.org/performerIn</example>
        [DataMember(Name = "performerIn")]
        public Event PerformerIn { get; set; }

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
        /// While such policies are most typically expressed in natural 
        /// language, sometimes related information (e.g. indicating a funder)
        /// can be expressed using schema.org terminology.
        /// </remarks>
        /// <example>https://schema.org/publishingPrinciples</example>
        [DataMember(Name = "publishingPrinciples")]
        public CreativeWorkRef PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        /// <example>https://schema.org/relatedTo</example>
        [DataMember(Name = "relatedTo")]
        public List<Person> RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or 
        /// person (demand).
        /// </summary>
        /// <example>https://schema.org/seeks</example>
        [DataMember(Name = "seeks")]
        public Demand Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        /// <seealso cref="Siblings"/>
        /// <example>https://schema.org/sibling</example>
        [DataMember(Name = "sibling")]
        public Person Sibling { get; set; }

        /// <summary>
        /// A list of siblings of the person.
        /// </summary>
        /// <seealso cref="Sibling"/>
        /// <example>https://schema.org/siblings</example>
        [DataMember(Name = "siblings")]
        public List<Person> Siblings { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, 
        /// promise, or financial contribution. e.g. a sponsor of a Medical 
        /// Study or a corporate sponsor of an event.
        /// </summary>
        /// <example>https://schema.org/sponsor</example>
        [DataMember(Name = "sponsor")]
        public OrganizationOrPerson Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        /// <example>https://schema.org/spouse</example>
        [DataMember(Name = "spouse")]
        public Person Spouse { get; set; }

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

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        /// <example>https://schema.org/weight</example>
        [DataMember(Name = "weight")]
        public QuantitativeValue Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        /// <example>https://schema.org/workLocation</example>
        [DataMember(Name = "workLocation")]
        public ContactPointOrPlace WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        /// <example>https://schema.org/worksFor</example>
        [DataMember(Name = "worksFor")]
        public List<Organization> WorksFor { get; set; }
    }
}
