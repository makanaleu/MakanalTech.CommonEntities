using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible
{
    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
    [DataContract(Name = "Trip", Namespace = "https://schema.org/Trip")]
    public class Trip : Thing
    {
        /// <summary>
        /// The expected arrival time.
        /// </summary>
        /// <example>https://schema.org/arrivalTime</example>
        [DataMember(Name = "arrivalTime")]
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        /// <example>https://schema.org/departureTime</example>
        [DataMember(Name = "departureTime")]
        public DateTime DepartureTime { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that is part of this item, or 
        /// CreativeWork (in some sense).
        /// </summary>
        /// <seealso cref="IsPartOf"/>
        /// <example>https://schema.org/hasPart</example>
        [DataMember(Name = "hasPart")]
        public CreativeWorkOrTrip HasPart { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that this item, or CreativeWork 
        /// (in some sense), is part of.
        /// </summary>
        /// <seealso cref="HasPart"/>
        /// <example>https://schema.org/isPartOf</example>
        [DataMember(Name = "isPartOf")]
        public CreativeWorkOrTrip IsPartOf { get; set; }

        /// <summary>
        /// An offer to provide this item—for example, an offer to sell a 
        /// product, rent the DVD of a movie, perform a service, or give away 
        /// tickets to an event.
        /// </summary>
        /// <example>https://schema.org/offers</example>
        [DataMember(Name = "offers")]
        public List<Offer> Offers { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the 
        /// goods producer.
        /// </summary>
        /// <remarks>
        /// Another party (a seller) may offer those services or goods on 
        /// behalf of the provider. A provider may also serve as the seller.
        /// </remarks>
        /// <example>https://schema.org/provider</example>
        [DataMember(Name = "provider")]
        public OrganizationOrPerson Provider { get; set; }
    }
}
