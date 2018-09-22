using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A delivery service through which content is provided via broadcast over
    /// the air or online.
    /// </summary>
    [DataContract(Name = "BroadcastService", Namespace = "https://schema.org/BroadcastService")]
    public class BroadcastService : Service
    {
        /// <summary>
        /// The media network(s) whose content is broadcast on this station.
        /// </summary>
        /// <example>https://schema.org/broadcastAffiliateOf</example>
        [DataMember(Name = "broadcastAffiliateOf")]
        public Organization BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it
        /// is the network name.
        /// </summary>
        /// <example>https://schema.org/broadcastDisplayName</example>
        [DataMember(Name = "broadcastDisplayName")]
        public Text BroadcastDisplayName { get; set; }

        /// <summary>
        /// The timezone in ISO 8601 format for which the service bases its 
        /// broadcasts.
        /// http://en.wikipedia.org/wiki/ISO_8601
        /// </summary>
        /// <example>https://schema.org/broadcastTimezone</example>
        [DataMember(Name = "broadcastTimezone")]
        public Text BroadcastTimezone { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        /// <example>https://schema.org/broadcaster</example>
        [DataMember(Name = "broadcaster")]
        public Organization Broadcaster { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong
        /// to such as regional variations of a national channel.
        /// </summary>
        /// <example>https://schema.org/parentService</example>
        [DataMember(Name = "parentService")]
        public BroadcastService ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 
        /// 3D, SD, HD, etc.).
        /// </summary>
        /// <example>https://schema.org/videoFormat</example>
        [DataMember(Name = "videoFormat")]
        public Text VideoFormat { get; set; }
    }
}
