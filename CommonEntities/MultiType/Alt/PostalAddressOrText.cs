using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// PostalAddressOrText MultiType accepts Postal Address or Text (string).
    /// </summary>
    [DataContract(Name = "PostalAddressOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class PostalAddressOrText : Text
    {
        /// <summary>
        /// PostalAddressOrText as a PostalAddress.
        /// </summary>
        [DataMember(Name = "asPostalAddress")]
        public PostalAddress AsPostalAddress;

        /// <summary>
        /// PostalAddressOrText as a PostalAddress.
        /// </summary>
        /// <param name="postalAddress">PostalAddressOrText as a PostalAddress.</param>
        public PostalAddressOrText(PostalAddress postalAddress) 
            : base(postalAddress.StreetAddress.AsText)
        {
            AsPostalAddress = postalAddress;
        }

        /// <summary>
        /// PostalAddressOrText as a Text (string).
        /// </summary>
        /// <param name="text">PostalAddressOrText as a Text (string).</param>
        public PostalAddressOrText(string text) : base(text)
        {
        }
    }
}
