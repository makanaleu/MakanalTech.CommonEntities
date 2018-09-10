using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ProductModelOrText MultiType accepts a ProductModel or Text.
    /// </summary>
    /// <example>https://schema.org/model</example>
    [DataContract(Name = "ProductModelOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class ProductModelOrText : Text
    {
        /// <summary>
        /// ProductModelOrText as a ProductModel.
        /// </summary>
        [DataMember(Name = "asProductModel")]
        public ProductModel AsProductModel;

        /// <summary>
        /// ProductModelOrText as a ProductModel.
        /// </summary>
        /// <param name="productModel">ProductModelOrText as a ProductModel.</param>
        public ProductModelOrText(ProductModel productModel) 
            : base(productModel.Name.AsText)
        {
            AsProductModel = productModel;
        }

        /// <summary>
        /// ProductModelOrText as a Text.
        /// </summary>
        /// <param name="text">ProductModelOrText as a Text.</param>
        public ProductModelOrText(Text text) : base(text.AsText) { }

        /// <summary>
        /// ProductModelOrText.
        /// </summary>
        public ProductModelOrText() : base() { }
    }
}
