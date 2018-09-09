using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.StructuredValue
{
    /// <summary>
    /// A structured value providing information about when a certain 
    /// organization or person owned a certain product.
    /// </summary>
    [DataContract(Name = "OwnershipInfo", Namespace = "https://schema.org/OwnershipInfo")]
    public class OwnershipInfo : Thing
    {
        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        /// <example>https://schema.org/acquiredFrom</example>
        [DataMember(Name = "acquiredFrom")]
        public OrganizationOrPerson AcquiredFrom { get; set; }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        /// <example>https://schema.org/ownedFrom</example>
        [DataMember(Name = "ownedFrom")]
        public DateTime OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        /// <example>https://schema.org/ownedThrough</example>
        [DataMember(Name = "ownedThrough")]
        public DateTime OwnedThrough { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        /// <example>https://schema.org/typeOfGood</example>
        [DataMember(Name = "typeOfGood")]
        public ProductOrService TypeOfGood { get; set; }
    }
}
