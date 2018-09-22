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
        /// QuantitativeValueOrDistance as a QuantitativeValue.
        /// </summary>
        [DataMember(Name = "asQuantitativeValue")]
        public QuantitativeValue AsQuantitativeValue;

        /// <summary>
        /// QuantitativeValueOrDistance as a Distance.
        /// </summary>
        [DataMember(Name = "asDistance")]
        public Distance AsDistance;

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
