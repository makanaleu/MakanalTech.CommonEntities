using MakanalTech.CommonEntities.Core.Intangible.Quantity;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// QuantitativeValueOrDistance MultiType accepts Distance or QuantitativeValue.
    /// </summary>
    /// <example>https://schema.org/height</example>
    [DataContract(Name = "QuantitativeValueOrDistance", Namespace = "CommonEntities.MultiType.Alt")]
    public class QuantitativeValueOrDistance
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string? ApplicationKey { get; set; }

        /// <summary>
        /// QuantitativeValueOrDistance as a QuantitativeValue.
        /// </summary>
        [DataMember(Name = "asQuantitativeValue")]
        public QuantitativeValue AsQuantitativeValue { get; set; }

        /// <summary>
        /// QuantitativeValueOrDistance as a Distance.
        /// </summary>
        [DataMember(Name = "asDistance")]
        public Distance AsDistance { get; set; }

        /// <summary>
        /// QuantitativeValueOrDistance as a QuantitativeValue.
        /// </summary>
        /// <param name="quantitativeValue">QuantitativeValueOrDistance as a QuantitativeValue.</param>
        public QuantitativeValueOrDistance(QuantitativeValue quantitativeValue)
        {
            AsQuantitativeValue = quantitativeValue;
        }

        /// <summary>
        /// QuantitativeValueOrDistance as a Distance.
        /// </summary>
        /// <param name="distance">QuantitativeValueOrDistance as a Distance.</param>
        public QuantitativeValueOrDistance(Distance distance)
        {
            AsDistance = distance;
        }

        /// <summary>
        /// QuantitativeValueOrDistance.
        /// </summary>
        public QuantitativeValueOrDistance() { }
    }
}
