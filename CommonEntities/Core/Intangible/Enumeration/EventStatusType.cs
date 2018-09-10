using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several 
    /// states that an Event may be in.
    /// </summary>
    [DataContract(Name = "EventStatusType", Namespace = "https://schema.org/EventStatusType")]
    public enum EventStatusType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// The event has been cancelled. If the event has multiple startDate 
        /// values, all are assumed to be cancelled. Either startDate or 
        /// previousStartDate may be used to specify the event's cancelled 
        /// date(s).
        /// </summary>
        /// <example>https://schema.org/EventCancelled</example>
        [EnumMember(Value = "EventCancelled")]
        EventCancelled = 10,

        /// <summary>
        /// The event has been postponed and no new date has been set. The 
        /// event's previousStartDate should be set.
        /// </summary>
        /// <example>https://schema.org/EventPostponed</example>
        [EnumMember(Value = "EventPostponed")]
        EventPostponed = 20,

        /// <summary>
        /// The event has been rescheduled. The event's previousStartDate 
        /// should be set to the old date and the startDate should be set to 
        /// the event's new date. (If the event has been rescheduled multiple 
        /// times, the previousStartDate property may be repeated).
        /// </summary>
        /// <example>https://schema.org/EventRescheduled</example>
        [EnumMember(Value = "EventRescheduled")]
        EventRescheduled = 30,

        /// <summary>
        /// The event is taking place or has taken place on the startDate as 
        /// scheduled. Use of this value is optional, as it is assumed by default.
        /// </summary>
        /// <example>https://schema.org/EventScheduled</example>
        [EnumMember(Value = "EventScheduled")]
        EventScheduled = 40
    }
}
