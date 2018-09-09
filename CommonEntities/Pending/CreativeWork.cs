using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using CommonEntities.MultiType.AltRef;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;
using DateTime = CommonEntities.DataType.DateTime;

namespace CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.CreativeWork.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "CreativeWork", Namespace = "https://pending.schema.org/CreativeWork")]
    public class CreativeWork : Core.CreativeWork
    {
        /// <summary>
        /// The specific time described by a creative work, for works (e.g. 
        /// articles, video objects etc.) that emphasise a particular moment 
        /// within an Event.
        /// </summary>
        /// <example>https://pending.schema.org/contentReferenceTime</example>
        [DataMember(Name = "contentReferenceTime")]
        public DateTime ContentReferenceTime { get; set; }

        /// <summary>
        /// Indicates a correction to a CreativeWork, either via a 
        /// CorrectionComment, textually or in another document.
        /// </summary>
        /// <example>https://pending.schema.org/correction</example>
        [DataMember(Name = "correction")]
        public CorrectionCommentOrTextRef Correction { get; set; }

        /// <summary>
        /// Indicates the date on which the current structured data was 
        /// generated / published.
        /// </summary>
        /// <seealso cref="SDPublisher"/>
        /// <example>https://pending.schema.org/sdDatePublished</example>
        [DataMember(Name = "sdDatePublished")]
        public Date SDDatePublished { get; set; }

        /// <summary>
        /// A license document that applies to this structured data, typically
        /// indicated by URL.
        /// </summary>
        /// <example>https://pending.schema.org/sdLicense</example>
        [DataMember(Name = "sdLicense")]
        public CreativeWorkRef SDLicense { get; set; }

        /// <summary>
        /// Indicates the party responsible for generating and publishing the 
        /// current structured data markup, typically in cases where the 
        /// structured data is derived automatically from existing published 
        /// content but published on a different site.
        /// </summary>
        /// <remarks>
        /// For example, student projects and open data initiatives often 
        /// re-publish existing content with more explicitly structured metadata.
        /// The SDPublisher property helps make such practices more explicit.
        /// </remarks>
        /// <example>https://pending.schema.org/sdPublisher</example>
        [DataMember(Name = "sdPublisher")]
        public OrganizationOrPerson SDPublisher { get; set; }
    }
}
