using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// BrandOrOrganization MultiType accepts either Brand or Organization.
    /// </summary>
    [DataContract(Name = "BrandOrOrganization", Namespace = "CommonEntities.MultiType.Alt")]
    public class BrandOrOrganization
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// BrandOrOrganization as a Brand.
        /// </summary>
        [DataMember(Name = "asBrand")]
        public Brand AsBrand { get; set; }

        /// <summary>
        /// BrandOrOrganization as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization { get; set; }

        /// <summary>
        /// BrandOrOrganization as a Brand.
        /// </summary>
        /// <param name="brand">BrandOrOrganization as a Brand.</param>
        public BrandOrOrganization(Brand brand)
        {
            AsBrand = brand;
        }

        /// <summary>
        /// BrandOrOrganization as an Organization.
        /// </summary>
        /// <param name="organization">BrandOrOrganization as an Organization.</param>
        public BrandOrOrganization(Organization organization)
        {
            AsOrganization = organization;
        }

        /// <summary>
        /// BrandOrOrganization.
        /// </summary>
        public BrandOrOrganization() { }
    }
}
