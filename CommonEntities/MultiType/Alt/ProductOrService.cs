using CommonEntities.Core;
using CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ContactPointOrPlace MultiType accepts ContactPoint or Place.
    /// </summary>
    [DataContract(Name = "ContactPointOrPlace", Namespace = "CommonEntities.MultiType.Alt")]
    public class ProductOrService
    {
        /// <summary>
        /// ProductOrService as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct;

        /// <summary>
        /// ProductOrService as a Service.
        /// </summary>
        [DataMember(Name = "asService")]
        public Service AsService;

        /// <summary>
        /// ProductOrService as a Product.
        /// </summary>
        /// <param name="product">ProductOrService as a Product.</param>
        public ProductOrService(Product product)
        {
            AsProduct = product;
        }

        /// <summary>
        /// ProductOrService as a Service.
        /// </summary>
        /// <param name="service">ProductOrService as a Service.</param>
        public ProductOrService(Service service)
        {
            AsService = service;
        }

        /// <summary>
        /// ProductOrService.
        /// </summary>
        public ProductOrService() { }
    }
}
