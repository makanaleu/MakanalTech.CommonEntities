using CommonEntities.Core;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// ProductTextOrUrl MultiType accepts Product or TextRef.
    /// </summary>
    [DataContract(Name = "ProductOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class ProductOrTextRef
    {
        /// <summary>
        /// ProductTextOrUrl as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct;

        /// <summary>
        /// ProductTextOrUrl as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef;

        /// <summary>
        /// ProductTextOrUrl as a Product.
        /// </summary>
        /// <param name="product">ProductTextOrUrl as a Product.</param>
        public ProductOrTextRef(Product product)
        {
            AsProduct = product;
        }

        /// <summary>
        /// ProductTextOrUrl as a TextRef.
        /// </summary>
        /// <param name="product">ProductTextOrUrl as a TextRef.</param>
        public ProductOrTextRef(TextRef textRef)
        {
            AsTextRef = textRef;
        }
    }
}
