using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// An email message.
    /// </summary>
    [DataContract(Name = "EmailMessage", Namespace = "https://schema.org/EmailMessage")]
    public class EmailMessage : Message
    {
    }
}
