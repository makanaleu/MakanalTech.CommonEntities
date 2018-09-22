using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending.Intangible
{
    /// <summary>
    /// Pending Extension of Core.Intangible.Trip.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Trip", Namespace = "https://pending.schema.org/Trip")]
    public class Trip : Core.Intangible.Trip
    {
        /// <summary>
        /// Destination(s) ( Place ) that make up a trip. For a trip where 
        /// destination order is important use ItemList to specify that order 
        /// (see examples).
        /// </summary>
        /// <example>https://pending.schema.org/itinerary</example>
        [DataMember(Name = "itinerary")]
        public ItemListOrPlace Itinerary { get; set; }
    }
}
