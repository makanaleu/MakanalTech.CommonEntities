using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A WebSite is a set of related web pages and other items typically 
    /// served from a single web domain and accessible via URLs.
    /// </summary>
    [DataContract(Name = "WebSite", Namespace = "https://schema.org/WebSite")]
    public class WebSite : CreativeWork
    {
        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies 
        /// this serial publication. You can repeat this property to identify 
        /// different formats of, or the linking ISSN (ISSN-L) for, this serial
        /// publication.
        /// </summary>
        /// <example>https://schema.org/issn</example>
        [DataMember(Name = "issn")]
        public Text Issn { get; set; }
    }
}
