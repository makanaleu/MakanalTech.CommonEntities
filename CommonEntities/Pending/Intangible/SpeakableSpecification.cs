using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Pending.Intangible.StructuredValue
{
    /// <summary>
    /// A SpeakableSpecification indicates (typically via xpath or cssSelector)
    /// sections of a document that are highlighted as particularly speakable. 
    /// Instances of this type are expected to be used primarily as values of 
    /// the speakable property.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "SpeakableSpecification", Namespace = "https://pending.schema.org/SpeakableSpecification")]
    public class SpeakableSpecification : Thing
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
