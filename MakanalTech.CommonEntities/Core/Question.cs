using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or 
    /// collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
    [DataContract(Name = "Question", Namespace = "https://schema.org/Question")]
    public class Question
    {
        /// <summary>
        /// The answer(s) that has been accepted as best, typically on a 
        /// Question/Answer site.
        /// </summary>
        /// <remarks>
        /// Sites vary in their selection mechanisms, e.g. drawing on community
        /// opinion and/or the view of the Question author.
        /// </remarks>
        /// <example>https://schema.org/acceptedAnswer</example>
        [DataMember(Name = "acceptedAnswer")]
        public AnswerOrItemList AcceptedAnswer { get; set; }

        /// <summary>
        /// The number of answers this question has received.
        /// </summary>
        /// <example>https://schema.org/answerCount</example>
        [DataMember(Name = "answerCount")]
        public int AnswerCount { get; set; }

        /// <summary>
        /// The number of downvotes this question, answer or comment has 
        /// received from the community.
        /// </summary>
        /// <example>https://schema.org/downvoteCount</example>
        [DataMember(Name = "downvoteCount")]
        public int DownvoteCount { get; set; }

        /// <summary>
        /// An answer (possibly one of several, possibly incorrect) to a 
        /// Question, e.g. on a Question/Answer site.
        /// </summary>
        /// <example>https://schema.org/suggestedAnswer</example>
        [DataMember(Name = "suggestedAnswer")]
        public AnswerOrItemList SuggestedAnswer { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received
        /// from the community.
        /// </summary>
        /// <example>https://schema.org/upvoteCount</example>
        [DataMember(Name = "upvoteCount")]
        public int UpvoteCount { get; set; }
    }
}
