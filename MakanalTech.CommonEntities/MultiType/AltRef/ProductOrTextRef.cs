using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.MultiType.Ref;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// ProductTextOrUrl MultiType accepts Product or TextRef.
    /// </summary>
    [DataContract(Name = "ProductOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class ProductOrTextRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// ProductTextOrUrl as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct { get; set; }

        /// <summary>
        /// ProductTextOrUrl as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef { get; set; }

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
        /// <param name="textRef">ProductTextOrUrl as a TextRef.</param>
        public ProductOrTextRef(TextRef textRef)
        {
            AsTextRef = textRef;
        }

        /// <summary>
        /// ProductOrTextRef.
        /// </summary>
        public ProductOrTextRef() { }
    }
}
