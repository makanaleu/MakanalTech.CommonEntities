using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ContactPointOrPlace MultiType accepts ContactPoint or Place.
    /// </summary>
    [DataContract(Name = "ContactPointOrPlace", Namespace = "CommonEntities.MultiType.Alt")]
    public class ProductOrService
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// ProductOrService as a Product.
        /// </summary>
        [DataMember(Name = "asProduct")]
        public Product AsProduct { get; set; }

        /// <summary>
        /// ProductOrService as a Service.
        /// </summary>
        [DataMember(Name = "asService")]
        public Service AsService { get; set; }

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
