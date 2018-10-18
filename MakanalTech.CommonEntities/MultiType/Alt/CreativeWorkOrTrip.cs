using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// CreativeWorkOrTrip MultiType accepts either CreativeWork or Trip.
    /// </summary>
    [DataContract(Name = "CreativeWorkOrTrip", Namespace = "CommonEntities.MultiType.Alt")]
    public class CreativeWorkOrTrip
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// CreativeWorkOrTrip as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork { get; set; }

        /// <summary>
        /// CreativeWorkOrTrip as a Trip.
        /// </summary>
        [DataMember(Name = "asTrip")]
        public Trip AsTrip { get; set; }

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

        /// <summary>
        /// CreativeWorkOrTrip.
        /// </summary>
        public CreativeWorkOrTrip() { }
    }
}
