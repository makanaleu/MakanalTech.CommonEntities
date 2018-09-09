using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated
    /// or wrong.
    /// </summary>
    [DataContract(Name = "Answer", Namespace = "https://schema.org/Answer")]
    public class Answer : Comment
    {
    }
}
