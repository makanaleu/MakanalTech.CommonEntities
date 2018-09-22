using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a 
    /// prototypical description).
    /// </summary>
    [DataContract(Name = "ProductModel", Namespace = "https://schema.org/ProductModel")]
    public class ProductModel : Product
    {
        /// <summary>
        /// A pointer to a base product from which this product is a variant. 
        /// It is safe to infer that the variant inherits all product features 
        /// from the base model, unless defined locally. This is not transitive.
        /// </summary>
        /// <example>https://schema.org/isVariantOf</example>
        [DataMember(Name = "isVariantOf")]
        public ProductModel IsVariantOf { get; set; }

        /// <summary>
        /// A pointer from a previous, often discontinued variant of the product
        /// to its newer variant.
        /// </summary>
        /// <example>https://schema.org/predecessorOf</example>
        [DataMember(Name = "predecessorOf")]
        public ProductModel PredecessorOf { get; set; }

        /// <summary>
        /// A pointer from a newer variant of a product to its previous, often
        /// discontinued predecessor.
        /// </summary>
        /// <example>https://schema.org/successorOf</example>
        [DataMember(Name = "successorOf")]
        public ProductModel SuccessorOf { get; set; }
    }
}
