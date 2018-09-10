using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// Text representing an XPath (typically but not necessarily version 1.0).
    /// </summary>
    [DataContract(Name = "XPathType", Namespace = "https://schema.org/XPathType")]
    public class XPathType : Text
    {
        /// <summary>
        /// Text representing an XPath (typically but not necessarily version
        /// 1.0).
        /// </summary>
        /// <param name="text">
        /// Text representing an XPath (typically but not necessarily version
        /// 1.0).
        /// </param>
        public XPathType(Text text) : base(text.AsText) { }

        /// <summary>
        /// XPathType.
        /// </summary>
        public XPathType() : base() { }
    }
}
