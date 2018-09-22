using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Action", Namespace = "https://schema.org/Action")]
    public class WebPageElement
    {
        /// <summary>
        /// A CSS selector, e.g. of a SpeakableSpecification or WebPageElement.
        /// In the latter case, multiple matches within a page can constitute a
        /// single conceptual "Web page element".
        /// </summary>
        /// <example>https://pending.schema.org/cssSelector</example>
        [DataMember(Name = "cssSelector")]
        public CssSelectorType CssSelector { get; set; }

        /// <summary>
        /// An XPath, e.g. of a SpeakableSpecification or WebPageElement. In 
        /// the latter case, multiple matches within a page can constitute a 
        /// single conceptual "Web page element".
        /// </summary>
        /// <example>https://pending.schema.org/xpath</example>
        [DataMember(Name = "xpath")]
        public XPathType Xpath { get; set; }
    }
}
