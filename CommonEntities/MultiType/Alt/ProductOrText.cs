using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ProductOrText MultiType accepts Product or Text.
    /// </summary>
    [DataContract(Name = "ProductOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class ProductOrText : Text
    {
        /// <summary>
        /// ProductOrText as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct;

        /// <summary>
        /// ProductOrText as a Product.
        /// </summary>
        /// <param name="product">ProductOrText as a Product.</param>
        public ProductOrText(Product product) : base(product.Name.AsText)
        {
            AsProduct = product;
        }

        /// <summary>
        /// ProductOrText as Text.
        /// </summary>
        /// <param name="text">ProductOrText as Text.</param>
        public ProductOrText(Text text) : base(text.AsText) { }

        /// <summary>
        /// ProductOrText.
        /// </summary>
        public ProductOrText() : base() { }
    }
}
