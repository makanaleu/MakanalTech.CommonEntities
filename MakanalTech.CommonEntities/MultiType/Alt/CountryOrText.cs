using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// CountryOrText MultiType accepts a Country or Text string.
    /// </summary>
    /// <example>https://schema.org/addressCountry</example>
    [DataContract(Name = "CountryOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class CountryOrText : Text
    {
        /// <summary>
        /// CountryOrText as a Country.
        /// </summary>
        [DataMember(Name = "asCountry")]
        public Country AsCountry;

        /// <summary>
        /// CountryOrText as a Country.
        /// </summary>
        /// <param name="country">CountryOrText as a Country.</param>
        public CountryOrText(Country country) : base(country.Name.AsText)
        {
            AsCountry = country;
        }

        /// <summary>
        /// CountryOrText as a Text.
        /// </summary>
        /// <param name="country">CountryOrText as a Text.</param>
        public CountryOrText(string country) : base(country) { }

        /// <summary>
        /// CountryOrText.
        /// </summary>
        public CountryOrText() : base() { }
    }
}
