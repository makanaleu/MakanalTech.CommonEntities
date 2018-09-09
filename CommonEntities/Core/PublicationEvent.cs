using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication
    /// for a CreativeWork of any type e.g. a broadcast event, an on-demand 
    /// event, a book/journal publication via a variety of delivery media.
    /// </summary>
    [DataContract(Name = "PublicationEvent", Namespace = "https://schema.org/PublicationEvent")]
    public class PublicationEvent : Event
    {
        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        /// <example>https://schema.org/publishedOn</example>
        [DataMember(Name = "publishedOn")]
        public BroadcastService PublishedOn { get; set; }
    }
}
