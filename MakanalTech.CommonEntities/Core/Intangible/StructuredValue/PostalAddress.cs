using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// The mailing address.
    /// </summary>
    [DataContract(Name = "PostalAddress", Namespace = "https://schema.org/PostalAddress")]
    public class PostalAddress : ContactPoint
    {
        /// <summary>
        /// The country. For example, USA. You can also provide the two-letter
        /// ISO 3166-1 alpha-2 country code.
        /// </summary>
        /// <remarks>
        /// See http://en.wikipedia.org/wiki/ISO_3166-1.
        /// </remarks>
        /// <example>https://schema.org/addressCountry</example>
        [DataMember(Name = "addressCountry")]
        public CountryOrText AddressCountry { get; set; }

        /// <summary>
        /// The locality. For example, Mountain View.
        /// </summary>
        /// <example>https://schema.org/addressLocality</example>
        [DataMember(Name = "addressLocality")]
        public Text AddressLocality { get; set; }

        /// <summary>
        /// The region. For example, CA.
        /// </summary>
        /// <example>https://schema.org/addressRegion</example>
        [DataMember(Name = "addressRegion")]
        public Text AddressRegion { get; set; }

        /// <summary>
        /// The post office box number for PO box addresses.
        /// </summary>
        /// <example>https://schema.org/postOfficeBoxNumber</example>
        [DataMember(Name = "postOfficeBoxNumber")]
        public Text PostOfficeBoxNumber { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        /// <example>https://schema.org/postalCode</example>
        [DataMember(Name = "postalCode")]
        public Text PostalCode { get; set; }

        /// <summary>
        /// The street address. For example, 1600 Amphitheatre Pkwy.
        /// </summary>
        /// <example>https://schema.org/streetAddress</example>
        [DataMember(Name = "streetAddress")]
        public Text StreetAddress { get; set; }
    }
}
