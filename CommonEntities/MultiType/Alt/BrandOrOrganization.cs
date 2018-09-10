using CommonEntities.Core;
using CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// BrandOrOrganization MultiType accepts either Brand or Organization.
    /// </summary>
    [DataContract(Name = "BrandOrOrganization", Namespace = "CommonEntities.MultiType.Alt")]
    public class BrandOrOrganization
    {
        /// <summary>
        /// BrandOrOrganization as a Brand.
        /// </summary>
        [DataMember(Name = "asBrand")]
        public Brand AsBrand;

        /// <summary>
        /// BrandOrOrganization as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization;

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
