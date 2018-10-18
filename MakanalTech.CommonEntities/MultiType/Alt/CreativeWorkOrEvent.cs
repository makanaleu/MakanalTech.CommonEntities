using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// CreativeWorkOrEvent MultiType accepts either CreativeWork or Event.
    /// </summary>
    [DataContract(Name = "CreativeWorkOrEvent", Namespace = "CommonEntities.MultiType.Alt")]
    public class CreativeWorkOrEvent
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string? ApplicationKey { get; set; }

        /// <summary>
        /// CreativeWorkOrEvent as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork { get; set; }

        /// <summary>
        /// CreativeWorkOrEvent as an Event.
        /// </summary>
        [DataMember(Name = "asEvent")]
        public Event AsEvent { get; set; }

        /// <summary>
        /// CreativeWorkOrEvent as a CreativeWork.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkOrEvent as a CreativeWork.</param>
        public CreativeWorkOrEvent(CreativeWork creativeWork)
        {
            AsCreativeWork = creativeWork;
        }

        /// <summary>
        /// CreativeWorkOrEvent as an Event.
        /// </summary>
        /// <param name="eventObject">CreativeWorkOrEvent as an Event.</param>
        public CreativeWorkOrEvent(Event eventObject)
        {
            AsEvent = eventObject;
        }

        /// <summary>
        /// CreativeWorkOrEvent.
        /// </summary>
        public CreativeWorkOrEvent() { }
    }
}
