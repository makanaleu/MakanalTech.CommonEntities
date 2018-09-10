using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// PropertyValueOrTextRef MultiType accepts PropertyValue or TextRef.
    /// </summary>
    /// <example>https://schema.org/identifier</example>
    [DataContract(Name = "PropertyValueOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class PropertyValueOrTextRef
    {
        /// <summary>
        /// PropertyValueOrTextRef as a PropertyValue.
        /// </summary>
        [DataMember(Name = "asPropertyValue")]
        public PropertyValue AsPropertyValue;

        /// <summary>
        /// PropertyValueOrTextRef as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef;

        /// <summary>
        /// PropertyValueOrTextRef as a PropertyValue.
        /// </summary>
        /// <param name="propertyValue">PropertyValueOrTextRef as a PropertyValue.</param>
        public PropertyValueOrTextRef(PropertyValue propertyValue)
        {
            AsPropertyValue = propertyValue;
        }

        /// <summary>
        /// PropertyValueOrTextRef as a TextRef.
        /// </summary>
        /// <param name="textRef">PropertyValueOrTextRef as a TextRef.</param>
        public PropertyValueOrTextRef(TextRef textRef)
        {
            AsTextRef = textRef;
        }

        /// <summary>
        /// PropertyValueOrTextRef.
        /// </summary>
        public PropertyValueOrTextRef() { }
    }
}
