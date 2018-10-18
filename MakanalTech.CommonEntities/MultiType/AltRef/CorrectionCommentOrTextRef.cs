using MakanalTech.CommonEntities.MultiType.Ref;
using MakanalTech.CommonEntities.Pending;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// CorrectionCommentOrTextRef MultiType accepts either CorrectionComment or TextRef.
    /// </summary>
    /// <example>https://pending.schema.org/correction</example>
    [DataContract(Name = "CorrectionCommentOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class CorrectionCommentOrTextRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// CorrectionCommentOrTextRef as a CorrectionComment.
        /// </summary>
        [DataMember(Name = "asCorrectionComment")]
        public CorrectionComment AsCorrectionComment { get; set; }

        /// <summary>
        /// CorrectionCommentOrTextRef as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef { get; set; }

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

        /// <summary>
        /// CorrectionCommentOrTextRef.
        /// </summary>
        public CorrectionCommentOrTextRef() { }
    }
}
