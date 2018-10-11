using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.Pending.Intangible;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// MediaSubscriptionOrBoolean MultiType accepts either a MediaSubscription or Boolean.
    /// </summary>
    /// <example>https://pending.schema.org/requiresSubscription</example>
    [DataContract(Name = "MediaSubscriptionOrBoolean", Namespace = "CommonEntities.MultiType.Alt")]
    public class MediaSubscriptionOrBoolean : Boolean
    {
        /// <summary>
        /// MediaSubscriptionOrBoolean as a MediaSubscription.
        /// </summary>
        [DataMember(Name = "asMediaSubscription")]
        public MediaSubscription AsMediaSubscription { get; set; }

        /// <summary>
        /// MediaSubscriptionOrBoolean as a MediaSubscription.
        /// </summary>
        /// <param name="mediaSubscription">MediaSubscriptionOrBoolean as a MediaSubscription.</param>
        public MediaSubscriptionOrBoolean(MediaSubscription mediaSubscription) : base(true)
        {
            AsMediaSubscription = mediaSubscription;
        }

        /// <summary>
        /// MediaSubscriptionOrBoolean as a boolean.
        /// </summary>
        /// <param name="value">MediaSubscriptionOrBoolean as a boolean.</param>
        public MediaSubscriptionOrBoolean(Boolean value) : base(value) { }

        /// <summary>
        /// MediaSubscriptionOrBoolean.
        /// </summary>
        public MediaSubscriptionOrBoolean() { }
    }
}
