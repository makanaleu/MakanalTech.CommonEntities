using CommonEntities.Core;
using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Combo
{
    /// <summary>
    /// PlacePostalAddressOrText MultiType accepts Place, PostalAddress, or Text (string).
    /// </summary>
    [DataContract(Name = "PlacePostalAddressOrText", Namespace = "CommonEntities.MultiType.Combo")]
    public class PlacePostalAddressOrText : Text
    {
        /// <summary>
        /// PlacePostalAddressOrText as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace;

        /// <summary>
        /// PlacePostalAddressOrText as a PostalAddress.
        /// </summary>
        [DataMember(Name = "asPostalAddress")]
        public PostalAddress AsPostalAddress;

        /// <summary>
        /// PlacePostalAddressOrText as a Place.
        /// </summary>
        /// <param name="place">PlacePostalAddressOrText as a Place.</param>
        public PlacePostalAddressOrText(Place place) : base(place.Name.AsText)
        {
            AsPlace = place;
        }

        /// <summary>
        /// PlacePostalAddressOrText as a PostalAddress.
        /// </summary>
        /// <param name="address">PostalAddressOrText as a PostalAddress.</param>
        public PlacePostalAddressOrText(PostalAddress address)
            : base(address.StreetAddress.AsText)
        {
            AsPostalAddress = address;
        }

        /// <summary>
        /// PostalAddressOrText as a Text (string).
        /// </summary>
        /// <param name="text">PostalAddressOrText as a Text (string).</param>
        public PlacePostalAddressOrText(string text) : base(text) { }

        /// <summary>
        /// PlacePostalAddressOrText.
        /// </summary>
        public PlacePostalAddressOrText() : base() { }
    }
}
