using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.WebPage.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "WebPage", Namespace = "https://pending.schema.org/WebPage")]
    public class WebPage : Core.WebPage
    {
        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' 
        /// in the sense  of being highlighted as being especially appropriate
        /// for text-to-speech conversion.
        /// </summary>
        /// <example>https://pending.schema.org/speakable</example>
        [DataMember(Name = "speakable")]
        public SpeakableSpecificationRef Speakable { get; set; }
    }
}
