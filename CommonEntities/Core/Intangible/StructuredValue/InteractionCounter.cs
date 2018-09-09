using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most
    /// cases, authors will use a subtype to specify the specific type of 
    /// interaction.
    /// </summary>
    [DataContract(Name = "InteractionCounter", Namespace = "https://schema.org/InteractionCounter")]
    public class InteractionCounter : Thing
    {
        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        /// <example>https://schema.org/interactionService</example>
        [DataMember(Name = "interactionService")]
        public SoftwareApplicationOrWebsite InteractionService { get; set; }

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s,
        /// etc. use LikeAction. For down votes use DislikeAction. Otherwise, 
        /// use the most specific Action.
        /// </summary>
        /// <example>https://schema.org/interactionType</example>
        [DataMember(Name = "interactionType")]
        public Action InteractionType { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the website or
        /// SoftwareApplication.
        /// </summary>
        /// <example>https://schema.org/userInteractionCount</example>
        [DataMember(Name = "userInteractionCount")]
        public Integer UserInteractionCount { get; set; }
    }
}
