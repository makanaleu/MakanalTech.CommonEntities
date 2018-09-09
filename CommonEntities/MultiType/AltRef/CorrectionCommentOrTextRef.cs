using CommonEntities.MultiType.Ref;
using CommonEntities.Pending;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// CorrectionCommentOrTextRef MultiType accepts either CorrectionComment or TextRef.
    /// </summary>
    /// <example>https://pending.schema.org/correction</example>
    [DataContract(Name = "CorrectionCommentOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class CorrectionCommentOrTextRef
    {
        /// <summary>
        /// CorrectionCommentOrTextRef as a CorrectionComment.
        /// </summary>
        [DataMember(Name = "asCorrectionComment")]
        public CorrectionComment AsCorrectionComment;

        /// <summary>
        /// CorrectionCommentOrTextRef as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef;

        /// <summary>
        /// CorrectionCommentOrTextRef as a CorrectionComment.
        /// </summary>
        /// <param name="correctionComment">CorrectionCommentOrTextRef as a CorrectionComment.</param>
        public CorrectionCommentOrTextRef(CorrectionComment correctionComment)
        {
            AsCorrectionComment = correctionComment;
        }

        /// <summary>
        /// CorrectionCommentOrTextRef as a TextRef.
        /// </summary>
        /// <param name="textRef">CorrectionCommentOrTextRef as a TextRef.</param>
        public CorrectionCommentOrTextRef(TextRef textRef)
        {
            AsTextRef = textRef;
        }
    }
}
