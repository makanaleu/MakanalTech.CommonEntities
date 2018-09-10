using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// Text representing a CSS selector.
    /// </summary>
    [DataContract(Name = "CssSelectorType", Namespace = "https://pending.schema.org/CssSelectorType")]
    public class CssSelectorType : Text
    {
        /// <summary>
        /// Text representing a CSS selector.
        /// </summary>
        /// <param name="text">Text representing a CSS selector.</param>
        public CssSelectorType(Text text) : base(text.AsText)
        {
        }
    }
}
