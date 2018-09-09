using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The 
    /// comment's content is expressed via the text property, and its topic via
    /// about, properties shared with all CreativeWorks.
    /// </summary>
    [DataContract(Name = "Comment", Namespace = "https://schema.org/Comment")]
    public class Comment
    {
        /// <summary>
        /// The number of downvotes this question, answer or comment has 
        /// received from the community.
        /// </summary>
        /// <example>https://schema.org/downvoteCount</example>
        [DataMember(Name = "downvoteCount")]
        public int DownvoteCount { get; set; }

        /// <summary>
        /// The parent of a question, answer or item in general.
        /// </summary>
        /// <example>https://schema.org/parentItem</example>
        [DataMember(Name = "parentItem")]
        public Question ParentItem { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received
        /// from the community.
        /// </summary>
        /// <example>https://schema.org/upvoteCount</example>
        [DataMember(Name = "upvoteCount")]
        public int UpvoteCount { get; set; }
    }
}
