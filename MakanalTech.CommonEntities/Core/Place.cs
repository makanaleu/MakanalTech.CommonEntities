using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    [DataContract(Name = "Place", Namespace = "https://schema.org/Place")]
    public class Place : Thing
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of
        /// the entitity, e.g. a product feature or another characteristic for 
        /// which there is no matching property in schema.org.
        /// </summary>
        /// <remarks>
        /// Note: Publishers should be aware that applications designed to use 
        /// specific schema.org properties (e.g. http://schema.org/width, 
        /// http://schema.org/color, http://schema.org/gtin13, ...) will 
        /// typically expect such data to be provided using those properties, 
        /// rather than using the generic property/value mechanism.
        /// </remarks>
        /// <example>https://schema.org/additionalProperty</example>
        [DataMember(Name = "additionalProperty")]
        public PropertyValue AdditionalProperty { get; set; }

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
        /// <example>https://schema.org/aggregateRating</example>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the 
        /// Accommodation.
        /// </summary>
        /// <remarks>
        /// This generic property does not make a statement about whether the 
        /// feature is included in an offer for the main accommodation or 
        /// available at extra costs.
        /// </remarks>
        /// <example>https://schema.org/amenityFeature</example>
        [DataMember(Name = "amenityFeature")]
        public LocationFeatureSpecification AmenityFeature { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely 
        /// identifies a place of business.
        /// </summary>
        /// <remarks>
        /// The code is typically assigned by the parentOrganization and used 
        /// in structured URLs. For example, in the URL 
        /// http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code
        /// "3047" is a branchCode for a particular branch.
        /// </remarks>
        /// <example>https://schema.org/branchCode</example>
        [DataMember(Name = "branchCode")]
        public Text BranchCode { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains
        /// it.
        /// </summary>
        /// <seealso cref="ContainsPlace"/>
        /// <example>https://schema.org/containedInPlace</example>
        [DataMember(Name = "containedInPlace")]
        public Place ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it
        /// contains.
        /// </summary>
        /// <seealso cref="ContainedInPlace"/>
        /// <example>https://schema.org/containsPlace</example>
        [DataMember(Name = "containsPlace")]
        public Place ContainsPlace { get; set; }

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
        /// The geo coordinates of the place.
        /// </summary>
        /// <example>https://schema.org/geo</example>
        [DataMember(Name = "geo")]
        public GeoCoordinatesOrGeoShape Geo { get; set; }

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
        /// A URL to a map of the place.
        /// </summary>
        /// <seealso cref="Maps"/>
        /// <example>https://schema.org/hasMap</example>
        [DataMember(Name = "hasMap")]
        public MapRef HasMap { get; set; }

        /// <summary>
        /// A list of maps of the place.
        /// </summary>
        /// <seealso cref="HasMap"/>
        /// <example>https://schema.org/maps</example>
        [DataMember(Name = "maps")]
        public List<MapRef> Maps { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for 
        /// free.
        /// </summary>
        /// <example>https://schema.org/isAccessibleForFree</example>
        [DataMember(Name = "isAccessibleForFree")]
        public Boolean IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All 
        /// Economic Activities (ISIC), Revision 4 code for a particular 
        /// organization, business person, or place.
        /// </summary>
        /// <example>https://schema.org/isicV4</example>
        [DataMember(Name = "isicV4")]
        public Text IsICv4 { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        /// <example>https://schema.org/logo</example>
        [DataMember(Name = "logo")]
        public ImageObjectRef Logo { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        /// <example>https://schema.org/maximumAttendeeCapacity</example>
        [DataMember(Name = "maximumAttendeeCapacity")]
        public Number MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        /// <example>https://schema.org/openingHoursSpecification</example>
        [DataMember(Name = "openingHoursSpecification")]
        public OpeningHoursSpecification OpeningHoursSpecification { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        /// <seealso cref="Photos"/>
        /// <example>https://schema.org/photo</example>
        [DataMember(Name = "photo")]
        public ImageObjectOrPhotograph Photo { get; set; }

        /// <summary>
        /// A list of photographs of this place.
        /// </summary>
        /// <seealso cref="Photo"/>
        /// <example>https://schema.org/photos</example>
        [DataMember(Name = "photos")]
        public List<ImageObjectOrPhotograph> Photos { get; set; }

        /// <summary>
        /// A flag to signal that the Place is open to public visitors.
        /// </summary>
        /// <remarks>
        /// If this property is omitted there is no assumed default boolean 
        /// value.
        /// </remarks>
        /// <example>https://schema.org/publicAccess</example>
        [DataMember(Name = "publicAccess")]
        public Boolean PublicAccess { get; set; }

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
        /// Indicates whether it is allowed to smoke in the place, e.g. in the 
        /// restaurant, hotel or hotel room.
        /// </summary>
        /// <example>https://schema.org/smokingAllowed</example>
        [DataMember(Name = "smokingAllowed")]
        public Boolean SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.
        /// </summary>
        /// <example>https://schema.org/specialOpeningHoursSpecification</example>
        [DataMember(Name = "specialOpeningHoursSpecification")]
        public OpeningHoursSpecification SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        /// <example>https://schema.org/telephone</example>
        [DataMember(Name = "telephone")]
        public Text Telephone { get; set; }
    }
}
