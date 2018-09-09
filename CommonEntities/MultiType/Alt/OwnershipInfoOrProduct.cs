using CommonEntities.Core;
using CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// OwnershipInfoOrProduct MultiType accepts OwnershipInfo or Product.
    /// </summary>
    [DataContract(Name = "OwnershipInfoOrProduct", Namespace = "CommonEntities.MultiType.Alt")]
    public class OwnershipInfoOrProduct
    {
        /// <summary>
        /// OwnershipInfoOrProduct as OwnershipInfo.
        /// </summary>
        [DataMember(Name = "asOwnershipInfo")]
        public OwnershipInfo AsOwnershipInfo;

        /// <summary>
        /// OwnershipInfoOrProduct as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct;

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
    }
}
