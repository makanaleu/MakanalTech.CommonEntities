using MakanalTech.CommonEntities.Core.Intangible.Quantity;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.MediaObject.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "MediaObject", Namespace = "https://pending.schema.org/MediaObject")]
    public class MediaObject : Core.MediaObject
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

        /// <summary>
        /// Indicates if use of the media require a subscription (either paid 
        /// or free).
        /// </summary>
        /// <remarks>
        /// Allowed values are true or false (note that an earlier version had 
        /// 'yes', 'no').
        /// </remarks>
        /// <example>https://pending.schema.org/requiresSubscription</example>
        [DataMember(Name = "requiresSubscription")]
        public MediaSubscriptionOrBoolean RequiresSubscription { get; set; }
    }
}
