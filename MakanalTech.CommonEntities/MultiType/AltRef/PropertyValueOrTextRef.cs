using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// PropertyValueOrTextRef MultiType accepts PropertyValue or TextRef.
    /// </summary>
    /// <example>https://schema.org/identifier</example>
    [DataContract(Name = "PropertyValueOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class PropertyValueOrTextRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// PropertyValueOrTextRef as a PropertyValue.
        /// </summary>
        [DataMember(Name = "asPropertyValue")]
        public PropertyValue AsPropertyValue { get; set; }

        /// <summary>
        /// PropertyValueOrTextRef as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef { get; set; }

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
