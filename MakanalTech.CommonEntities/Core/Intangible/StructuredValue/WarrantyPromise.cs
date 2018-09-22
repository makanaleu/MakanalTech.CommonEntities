using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A structured value representing the duration and scope of services that
    /// will be provided to a customer free of charge in case of a defect or 
    /// malfunction of a product.
    /// </summary>
    [DataContract(Name = "WarrantyPromise", Namespace = "https://schema.org/WarrantyPromise")]
    public class WarrantyPromise : Thing
    {
        /// <summary>
        /// The duration of the warranty promise. Common unitCode values are 
        /// ANN for year, MON for months, or DAY for days. 
        /// </summary>
        /// <example>https://schema.org/durationOfWarranty</example>
        [DataMember(Name = "durationOfWarranty")]
        public QuantitativeValue DurationOfWarranty { get; set; }

        /// <summary>
        /// The scope of the warranty promise.
        /// </summary>
        /// <example>https://schema.org/warrantyScope</example>
        [DataMember(Name = "warrantyScope")]
        public WarrantyScope WarrantyScope { get; set; }
    }
}
