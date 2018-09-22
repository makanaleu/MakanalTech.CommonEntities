using MakanalTech.CommonEntities.MultiType.Combo;
using System.Runtime.Serialization;
using DateTime = MakanalTech.CommonEntities.DataType.DateTime;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    [DataContract(Name = "Message", Namespace = "https://schema.org/Message")]
    public class Message : CreativeWork
    {
        /// <summary>
        /// A sub property of recipient. The recipient blind copied on a message.
        /// </summary>
        /// <example>https://schema.org/bccRecipient</example>
        [DataMember(Name = "bccRecipient")]
        public ContactPointOrOrganizationOrPerson BccRecipient { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        /// <example>https://schema.org/ccRecipient</example>
        [DataMember(Name = "ccRecipient")]
        public ContactPointOrOrganizationOrPerson CcRecipient { get; set; }

        /// <summary>
        /// The date/time at which the message has been read by the recipient
        /// if a single recipient exists.
        /// </summary>
        /// <example>https://schema.org/dateRead</example>
        [DataMember(Name = "dateRead")]
        public DateTime DateRead { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        /// <example>https://schema.org/dateReceived</example>
        [DataMember(Name = "dateReceived")]
        public DateTime DateReceived { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        /// <example>https://schema.org/dateSent</example>
        [DataMember(Name = "dateSent")]
        public DateTime DateSent { get; set; }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        /// <example>https://schema.org/messageAttachment</example>
        [DataMember(Name = "messageAttachment")]
        public CreativeWork MessageAttachment { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the 
        /// receiving end of the action.
        /// </summary>
        /// <example>https://schema.org/recipient</example>
        [DataMember(Name = "recipient")]
        public Recipient Recipient { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the 
        /// sending end of the action.
        /// </summary>
        /// <example>https://schema.org/sender</example>
        [DataMember(Name = "sender")]
        public AudienceOrOgranizationOrPerson Sender { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent 
        /// the message.
        /// </summary>
        /// <example>https://schema.org/toRecipient</example>
        [DataMember(Name = "toRecipient")]
        public Recipient ToRecipient { get; set; }
    }
}
