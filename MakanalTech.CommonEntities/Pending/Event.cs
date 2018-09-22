using MakanalTech.CommonEntities.Core.Intangible.Quantity;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.Event.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Event", Namespace = "https://pending.schema.org/Event")]
    public class Event : Core.Event
    {
        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in
        /// ISO 8601 date format.
        /// </summary>
        /// <remarks>
        /// See http://en.wikipedia.org/wiki/ISO_8601.
        /// </remarks>
        /// <example>https://pending.schema.org/duration</example>
        [DataMember(Name = "duration")]
        public Duration Duration { get; set; }
    }
}
