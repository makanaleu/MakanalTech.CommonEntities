using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    [DataContract(Name = "QuantitativeValue", Namespace = "https://schema.org/QuantitativeValue")]
    public class QuantitativeValue : Thing
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of
        /// the entitity, e.g. a product feature or another characteristic for 
        /// which there is no matching property in schema.org.
        /// </summary>
        /// <remarks>
        /// Note: Publishers should be aware that applications designed to use 
        /// specific schema.org properties (e.g. http://schema.org/width, 
        /// http://schema.org/color, http://schema.org/gtin13, ...) will 
        /// typically expect such data to be provided using those properties, 
        /// rather than using the generic property/value mechanism.
        /// </remarks>
        /// <example>https://schema.org/additionalProperty</example>
        [DataMember(Name = "additionalProperty")]
        public PropertyValue AdditionalProperty { get; set; }

        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        /// <example>https://schema.org/maxValue</example>
        [DataMember(Name = "maxValue")]
        public Number MaxValue { get; set; }

        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        /// <example>https://schema.org/minValue</example>
        [DataMember(Name = "minValue")]
        public Number MinValue { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 
        /// characters) or a URL. Other codes than the UN/CEFACT Common Code 
        /// may be used with a prefix followed by a colon.
        /// </summary>
        /// <example>https://schema.org/unitCode</example>
        [DataMember(Name = "unitCode")]
        public TextRef UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you
        /// cannot provide a standard unit code for unitCode.
        /// </summary>
        /// <example>https://schema.org/unitText</example>
        [DataMember(Name = "unitText")]
        public Text UnitText { get; set; }

        /// <summary>
        /// The value of the quantitative value or property value node.
        /// </summary>
        /// <remarks>
        /// For QuantitativeValue and MonetaryAmount, the recommended type for 
        /// values is 'Number'. For PropertyValue, it can be 'Text;', 'Number',
        /// 'Boolean', or 'StructuredValue'.
        /// </remarks>
        /// <example>https://schema.org/value</example>
        [DataMember(Name = "value")]
        public Number Value { get; set; } // TODO Handle any StructuredValue

        /// <summary>
        /// A pointer to a secondary value that provides additional information
        /// on the original value, e.g. a reference temperature.
        /// </summary>
        /// <example>https://schema.org/valueReference</example>
        [DataMember(Name = "valueReference")]
        public PropertyValue ValueReference { get; set; } // TODO Handle any StructuredValue
    }
}
