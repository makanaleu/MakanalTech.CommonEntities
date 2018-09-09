using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// CreativeWorkProductOrURL MultiType accepts either CreativeWork, Product or URL.
    /// </summary>
    [DataContract(Name = "CreativeWorkOrProductRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class CreativeWorkOrProductRef
    {
        /// <summary>
        /// CreativeWorkProductOrURL as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork;

        /// <summary>
        /// CreativeWorkProductOrURL as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct;

        /// <summary>
        /// CreativeWorkProductOrURL as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl;

        /// <summary>
        /// CreativeWorkProductOrURL as a CreativeWork.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkProductOrURL as a CreativeWork.</param>
        public CreativeWorkOrProductRef(CreativeWork creativeWork)
        {
            AsCreativeWork = creativeWork;
        }

        /// <summary>
        /// CreativeWorkProductOrURL as a Product.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkProductOrURL as a Product.</param>
        public CreativeWorkOrProductRef(Product product)
        {
            AsProduct = product;
        }

        /// <summary>
        /// CreativeWorkProductOrURL as a URL.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkProductOrURL as a URL.</param>
        public CreativeWorkOrProductRef(URL url)
        {
            AsUrl = url;
        }
    }
}
