using CommonEntities.DataType;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or 
    /// place. Use the 'name' property for the name of the property. If there 
    /// is an additional human-readable version of the value, put that into the
    /// 'description' property.
    /// </summary>
    /// <remarks>
    /// Always use specific schema.org properties when a) they exist and b) you
    /// can populate them. Using PropertyValue as a substitute will typically 
    /// not trigger the same effect as using the original, specific property.
    /// </remarks>
    [DataContract(Name = "PropertyValue", Namespace = "https://schema.org/PropertyValue")]
    public class PropertyValue : Thing
    {
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
        /// A commonly used identifier for the characteristic represented by 
        /// the property, e.g. a manufacturer or a standard code for a property. 
        /// </summary>
        /// <remarks>
        /// propertyID can be (1) a prefixed string, mainly meant to be used 
        /// with standards for product properties; (2) a site-specific, 
        /// non-prefixed string (e.g. the primary key of the property or the 
        /// vendor-specific id of the property), or (3) a URL indicating the 
        /// type of the property, either pointing to an external vocabulary, or
        /// a Web resource that describes the property (e.g. a glossary entry).
        /// Standards bodies should promote a standard prefix for the identifiers
        /// of properties from their standards.
        /// </remarks>
        /// <example>https://schema.org/propertyID</example>
        [DataMember(Name = "propertyID")]
        public TextRef PropertyID { get; set; }

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
