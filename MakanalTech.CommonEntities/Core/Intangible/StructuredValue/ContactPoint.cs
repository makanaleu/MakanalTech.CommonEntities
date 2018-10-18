using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A contact point—for example, a Customer Complaints department.
    /// </summary>
    [DataContract(Name = "ContactPoint", Namespace = "https://schema.org/ContactPoint")]
    public class ContactPoint
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided. 
        /// </summary>
        /// <example>https://schema.org/areaServed</example>
        [DataMember(Name = "areaServed")]
        public Area AreaServed { get; set; }

        /// <summary>
        /// A language someone may use with or at the item, service or place.  
        /// </summary>
        /// <remarks>
        /// Please use one of the language codes from the IETF BCP 47 standard.
        /// See http://tools.ietf.org/html/bcp47.
        /// </remarks>
        /// <example>https://schema.org/availableLanguage</example>
        [DataMember(Name = "availableLanguage")]
        public LanguageOrText AvailableLanguage { get; set; }

        /// <summary>
        /// An option available on this contact point (e.g. a toll-free number
        /// or support for hearing-impaired callers).  
        /// </summary>
        /// <example>https://schema.org/contactOption</example>
        [DataMember(Name = "contactOption")]
        public ContactPointOption ContactOption { get; set; }

        /// <summary>
        /// A person or organization can have different contact points, for 
        /// different purposes.  
        /// </summary>
        /// <remarks>
        /// For example, a sales contact point, a PR contact point and so on.
        /// This property is used to specify the kind of contact point.
        /// </remarks>
        /// <example>https://schema.org/contactType</example>
        [DataMember(Name = "contactType")]
        public Text ContactType { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        /// <example>https://schema.org/email</example>
        [DataMember(Name = "email")]
        public Text Email { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        /// <example>https://schema.org/faxNumber</example>
        [DataMember(Name = "faxNumber")]
        public Text FaxNumber { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        /// <example>https://schema.org/hoursAvailable</example>
        [DataMember(Name = "hoursAvailable")]
        public OpeningHoursSpecification HoursAvailable { get; set; }

        /// <summary>
        /// The product or service this support contact point is related to 
        /// (such as product support for a particular product line).
        /// </summary>
        /// <remarks>
        /// This can be a specific product or product line (e.g. "iPhone") or a
        /// general category of products or services 
        /// (e.g. "smartphones").
        /// </remarks>
        /// <example>https://schema.org/productSupported</example>
        [DataMember(Name = "productSupported")]
        public ProductOrText ProductSupported { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        /// <example>https://schema.org/telephone</example>
        [DataMember(Name = "telephone")]
        public Text Telephone { get; set; }
    }
}
