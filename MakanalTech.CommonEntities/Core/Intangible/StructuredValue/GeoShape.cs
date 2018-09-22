using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using 
    /// several properties whose values are based on latitude/longitude pairs. 
    /// Either whitespace or commas can be used to separate latitude and 
    /// longitude; whitespace should be used when writing a list of several 
    /// such points.
    /// </summary>
    [DataContract(Name = "GeoShape", Namespace = "https://schema.org/GeoShape")]
    public class GeoShape : Thing
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
        /// A box is the area enclosed by the rectangle formed by two points. 
        /// The first point is the lower corner, the second point is the upper 
        /// corner. A box is expressed as two points separated by a space 
        /// character.
        /// </summary>
        /// <example>https://schema.org/box</example>
        [DataMember(Name = "box")]
        public Text Box { get; set; }

        /// <summary>
        /// A circle is the circular region of a specified radius centered at a
        /// specified latitude and longitude. A circle is expressed as a pair 
        /// followed by a radius in meters.
        /// </summary>
        /// <example>https://schema.org/circle</example>
        [DataMember(Name = "circle")]
        public Text Circle { get; set; }

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
        /// A line is a point-to-point path consisting of two or more points. A
        /// line is expressed as a series of two or more point objects separated
        /// by space.
        /// </summary>
        /// <example>https://schema.org/line</example>
        [DataMember(Name = "line")]
        public Text Line { get; set; }

        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which 
        /// the starting and ending points are the same. A polygon is expressed
        /// as a series of four or more space delimited points where the first 
        /// and final points are identical.
        /// </summary>
        /// <example>https://schema.org/polygon</example>
        [DataMember(Name = "polygon")]
        public Text Polygon { get; set; }

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        /// <example>https://schema.org/postalCode</example>
        [DataMember(Name = "postalCode")]
        public Text PostalCode { get; set; }
    }
}
