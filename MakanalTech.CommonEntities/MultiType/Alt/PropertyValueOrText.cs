using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// PropertyValueOrText MultiType accepts PropertyValue or Text.
    /// </summary>
    /// <example>https://pending.schema.org/variableMeasured</example>
    [DataContract(Name = "PropertyValueOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class PropertyValueOrText : Text
    {
        /// <summary>
        /// PropertyValueOrText as a PropertyValue.
        /// </summary>
        [DataMember(Name = "asPropertyValue")]
        public PropertyValue AsPropertyValue;

        /// <summary>
        /// PropertyValueOrText as a PropertyValue.
        /// </summary>
        /// <param name="propertyValue">PropertyValueOrText as a PropertyValue.</param>
        public PropertyValueOrText(PropertyValue propertyValue) 
            : base (propertyValue.Value.AsText)
        {
            AsPropertyValue = propertyValue;
        }

        /// <summary>
        /// PropertyValueOrText as a Text.
        /// </summary>
        /// <param name="text">PropertyValueOrText as a Text.</param>
        public PropertyValueOrText(Text text) : base(text.AsText) { }

        /// <summary>
        /// PropertyValueOrText.
        /// </summary>
        public PropertyValueOrText() : base() { }
    }
}
