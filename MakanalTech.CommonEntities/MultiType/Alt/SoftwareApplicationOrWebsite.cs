using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// SoftwareApplicationOrWebsite MultiType accepts a SoftwareApplication or
    /// WebSite.
    /// </summary>
    /// <example>https://schema.org/interactionService</example>
    [DataContract(Name = "SoftwareApplicationOrWebsite", Namespace = "CommonEntities.MultiType.Alt")]
    public class SoftwareApplicationOrWebsite
    {
        /// <summary>
        /// SoftwareApplicationOrWebsite as a SoftwareApplication.
        /// </summary>
        [DataMember(Name = "asSoftwareApplication")]
        public SoftwareApplication AsSoftwareApplication;

        /// <summary>
        /// SoftwareApplicationOrWebsite as a WebSite.
        /// </summary>
        [DataMember(Name = "asWebSite")]
        public WebSite AsWebSite;

        /// <summary>
        /// SoftwareApplicationOrWebsite as a SoftwareApplication.
        /// </summary>
        /// <param name="softwareApplication">SoftwareApplicationOrWebsite as a SoftwareApplication.</param>
        public SoftwareApplicationOrWebsite(SoftwareApplication softwareApplication)
        {
            AsSoftwareApplication = softwareApplication;
        }

        /// <summary>
        /// SoftwareApplicationOrWebsite as a WebSite.
        /// </summary>
        /// <param name="webSite">SoftwareApplicationOrWebsite as a WebSite.</param>
        public SoftwareApplicationOrWebsite(WebSite webSite)
        {
            AsWebSite = webSite;
        }

        /// <summary>
        /// SoftwareApplicationOrWebsite.
        /// </summary>
        public SoftwareApplicationOrWebsite() { }
    }
}
