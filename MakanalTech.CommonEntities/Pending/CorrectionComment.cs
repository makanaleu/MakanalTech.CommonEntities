using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// A comment that corrects CreativeWork.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms which have 
    /// yet to be accepted into the core vocabulary. Pending terms are subject to 
    /// change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "CorrectionComment", Namespace = "https://pending.schema.org/CorrectionComment")]
    public class CorrectionComment : Core.Comment
    {
    }
}
