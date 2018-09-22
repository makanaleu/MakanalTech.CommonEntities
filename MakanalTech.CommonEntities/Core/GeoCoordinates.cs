using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    [DataContract(Name = "GeoCoordinates", Namespace = "https://schema.org/GeoCoordinates")]
    public class GeoCoordinates : Thing
    {
        /// <summary>
        /// Physical address of the item.
        /// </summary>
        /// <example>https://schema.org/address</example>
        [DataMember(Name = "address")]
        public PostalAddressOrText Address { get; set; }

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
        /// The elevation of a location (WGS 84).
        /// </summary>
        /// <remarks>
        /// See https://en.wikipedia.org/wiki/World_Geodetic_System.
        /// </remarks>
        /// <example>https://schema.org/elevation</example>
        [DataMember(Name = "elevation")]
        public Number Elevation { get; set; }

        /// <summary>
        /// The latitude of a location. For example 37.42242 (WGS 84).
        /// </summary>
        /// <remarks>
        /// See https://en.wikipedia.org/wiki/World_Geodetic_System.
        /// </remarks>
        /// <example>https://schema.org/latitude</example>
        [DataMember(Name = "latitude")]
        public Number Latitude { get; set; }

        /// <summary>
        /// The longitude of a location. For example -122.08585 (WGS 84).
        /// </summary>
        /// <remarks>
        /// See https://en.wikipedia.org/wiki/World_Geodetic_System.
        /// </remarks>
        /// <example>https://schema.org/longitude</example>
        [DataMember(Name = "longitude")]
        public Number Longitude { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        /// <example>https://schema.org/postalCode</example>
        [DataMember(Name = "postalCode")]
        public Text PostalCode { get; set; }
    }
}
