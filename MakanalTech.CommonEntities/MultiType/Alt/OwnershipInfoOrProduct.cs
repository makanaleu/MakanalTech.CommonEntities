using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// OwnershipInfoOrProduct MultiType accepts OwnershipInfo or Product.
    /// </summary>
    [DataContract(Name = "OwnershipInfoOrProduct", Namespace = "CommonEntities.MultiType.Alt")]
    public class OwnershipInfoOrProduct
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string? ApplicationKey { get; set; }

        /// <summary>
        /// OwnershipInfoOrProduct as OwnershipInfo.
        /// </summary>
        [DataMember(Name = "asOwnershipInfo")]
        public OwnershipInfo AsOwnershipInfo { get; set; }

        /// <summary>
        /// OwnershipInfoOrProduct as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct { get; set; }

        /// <summary>
        /// OwnershipInfoOrProduct as OwnershipInfo.
        /// </summary>
        /// <param name="ownershipInfo">OwnershipInfoOrProduct as OwnershipInfo.</param>
        public OwnershipInfoOrProduct(OwnershipInfo ownershipInfo)
        {
            AsOwnershipInfo = ownershipInfo;
        }

        /// <summary>
        /// OwnershipInfoOrProduct as a Product.
        /// </summary>
        /// <param name="product">OwnershipInfoOrProduct as a Product.</param>
        public OwnershipInfoOrProduct(Product product)
        {
            AsProduct = product;
        }

        /// <summary>
        /// OwnershipInfoOrProduct.
        /// </summary>
        public OwnershipInfoOrProduct() { }
    }
}
