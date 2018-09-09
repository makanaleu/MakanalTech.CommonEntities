using System.Runtime.Serialization;

namespace CommonEntities.Pending.Intangible
{
    /// <summary>
    /// A subscription which allows a user to access media including audio, 
    /// video, books, etc.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "MediaSubscription", Namespace = "https://pending.schema.org/MediaSubscription")]
    public class MediaSubscription 
    {
        /// <summary>
        /// The Organization responsible for authenticating the user's 
        /// subscription. For example, many media apps require a cable/satellite
        /// provider to authenticate your subscription before playing media.
        /// </summary>
        /// <example>https://pending.schema.org/authenticator</example>
        [DataMember(Name = "authenticator")]
        public Organization Authenticator { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the 
        /// Action. For example, the user may need to buy a movie before being 
        /// able to watch it.
        /// </summary>
        /// <example>https://pending.schema.org/expectsAcceptanceOf</example>
        [DataMember(Name = "expectsAcceptanceOf")]
        public Offer ExpectsAcceptanceOf { get; set; }
    }
}
