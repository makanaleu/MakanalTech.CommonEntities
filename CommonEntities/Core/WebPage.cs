using CommonEntities.Core.Intangible.Enumeration;
using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, 
    /// so the various properties about that webpage, such as breadcrumb may be used.
    /// </summary>
    /// <remarks>
    /// We recommend explicit declaration if these properties are specified, but if they are 
    /// found outside of an itemscope, they will be assumed to be about the page.
    /// </remarks>
    [DataContract(Name = "Person", Namespace = "https://schema.org/WebPage")]
    public class WebPage : CreativeWork
    {
        /// <summary>
        /// A set of links that can help a user understand and navigate a 
        /// website hierarchy.
        /// </summary>
        /// <example>https://schema.org/breadcrumb</example>
        [DataMember(Name = "breadcrumb")]
        public BreadcrumbListOrText Breadcrumb { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for 
        /// accuracy and/or completeness.
        /// </summary>
        /// <example>https://schema.org/lastReviewed</example>
        [DataMember(Name = "lastReviewed")]
        public Date LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        /// <example>https://schema.org/mainContentOfPage</example>
        [DataMember(Name = "mainContentOfPage")]
        public Pending.WebPageElement MainContentOfPage { get; set; }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        /// <example>https://schema.org/primaryImageOfPage</example>
        [DataMember(Name = "primaryImageOfPage")]
        public ImageObject PrimaryImageOfPage { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web 
        /// pages.
        /// </summary>
        /// <example>https://schema.org/relatedLink</example>
        [DataMember(Name = "relatedLink")]
        public URL RelatedLink { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web 
        /// page for accuracy and/or completeness.
        /// </summary>
        /// <example>https://schema.org/reviewedBy</example>
        [DataMember(Name = "reviewedBy")]
        public OrganizationOrPerson ReviewedBy { get; set; }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are 
        /// the non-navigation links that are clicked on the most. 
        /// </summary>
        /// <seealso cref="SignificantLinks"/>
        /// <example>https://schema.org/significantLink</example>
        [DataMember(Name = "significantLink")]
        public URL SignificantLink { get; set; }

        /// <summary>
        /// List of the more significant URLs on the page. Typically, these are
        /// the non-navigation links that are clicked on the most. 
        /// </summary>
        /// <seealso cref="SignificantLink"/>
        /// <example>https://schema.org/significantLinks</example>
        [DataMember(Name = "significantLinks")]
        public List<URL> SignificantLinks { get; set; }

        /// <summary>
        /// One of the domain specialities to which this web page's content 
        /// applies.
        /// </summary>
        /// <example>https://schema.org/specialty</example>
        [DataMember(Name = "specialty")]
        public Specialty Specialty { get; set; }
    }
}
