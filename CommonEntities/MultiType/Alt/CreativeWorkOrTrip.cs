using CommonEntities.Core;
using CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// CreativeWorkOrTrip MultiType accepts either CreativeWork or Trip.
    /// </summary>
    [DataContract(Name = "CreativeWorkOrTrip", Namespace = "CommonEntities.MultiType.Alt")]
    public class CreativeWorkOrTrip
    {
        /// <summary>
        /// CreativeWorkOrTrip as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork;

        /// <summary>
        /// CreativeWorkOrTrip as a Trip.
        /// </summary>
        [DataMember(Name = "asTrip")]
        public Trip AsTrip;

        /// <summary>
        /// CreativeWorkOrTrip as a CreativeWork.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkOrTrip as a CreativeWork.</param>
        public CreativeWorkOrTrip(CreativeWork creativeWork)
        {
            AsCreativeWork = creativeWork;
        }

        /// <summary>
        /// CreativeWorkOrTrip as a Trip.
        /// </summary>
        /// <param name="trip">CreativeWorkOrTrip as a Trip.</param>
        public CreativeWorkOrTrip(Trip trip)
        {
            AsTrip = trip;
        }
    }
}
