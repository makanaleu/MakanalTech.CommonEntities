using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and 
    /// business function of goods included in a bundle offer.
    /// </summary>
    [DataContract(Name = "TypeAndQuantityNode", Namespace = "https://schema.org/TypeAndQuantityNode")]
    public class TypeAndQuantityNode : Thing
    {
        /// <summary>
        /// The default BusinessFunction is 'Sell'.
        /// </summary>
        public TypeAndQuantityNode()
        {
            BusinessFunction = BusinessFunction.Sell;
        }

        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        /// <example>https://schema.org/amountOfThisGood</example>
        [DataMember(Name = "amountOfThisGood")]
        public Number AmountOfThisGood { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the
        /// offer or component of a bundle (TypeAndQuantityNode). The default 
        /// is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        /// <example>https://schema.org/businessFunction</example>
        [DataMember(Name = "businessFunction")]
        public BusinessFunction BusinessFunction { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        /// <example>https://schema.org/typeOfGood</example>
        [DataMember(Name = "typeOfGood")]
        public ProductOrService TypeOfGood { get; set; }

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
    }
}
