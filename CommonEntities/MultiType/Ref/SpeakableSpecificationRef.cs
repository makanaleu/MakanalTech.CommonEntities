using CommonEntities.DataType;
using CommonEntities.Pending.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Ref
{
    /// <summary>
    /// ArticleRef MultiType accepts either an Article or URL.
    /// </summary>
    /// <example>https://pending.schema.org/speakable</example>
    [DataContract(Name = "SpeakableSpecificationRef", Namespace = "CommonEntities.Multitype.Ref")]
    public class SpeakableSpecificationRef : URL
    {
        /// <summary>
        /// SpeakableSpecificationRef as a SpeakableSpecification.
        /// </summary>
        [DataMember(Name = "AsSpeakableSpecification")]
        public SpeakableSpecification AsSpeakableSpecification;

        /// <summary>
        /// SpeakableSpecificationRef as a SpeakableSpecification.
        /// </summary>
        /// <param name="speakableSpecification">SpeakableSpecificationRef as a SpeakableSpecification.</param>
        public SpeakableSpecificationRef(SpeakableSpecification speakableSpecification)
            : base(speakableSpecification.Name.AsText)
        {
            AsSpeakableSpecification = speakableSpecification;
        }

        /// <summary>
        /// SpeakableSpecificationRef as a URL.
        /// </summary>
        /// <param name="url">SpeakableSpecificationRef as a URL.</param>
        public SpeakableSpecificationRef(URL url) : base(url.AsText) { }

        /// <summary>
        /// SpeakableSpecificationRef.
        /// </summary>
        public SpeakableSpecificationRef() : base() { }
    }
}
