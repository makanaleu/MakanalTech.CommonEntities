using CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace CommonEntities.Pending
{
    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication
    /// for a CreativeWork of any type e.g. a broadcast event, an on-demand event,
    /// a book/journal publication via a variety of delivery media.
    /// </summary>
    [DataContract(Name = "PublicationEvent", Namespace = "https://pending.schema.org/PublicationEvent")]
    public class PublicationEvent : Core.PublicationEvent
    {
        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        /// <example>https://bib.schema.org/publishedBy</example>
        [DataMember(Name = "publishedBy")]
        public OrganizationOrPerson PublishedBy { get; set; }
    }
}
