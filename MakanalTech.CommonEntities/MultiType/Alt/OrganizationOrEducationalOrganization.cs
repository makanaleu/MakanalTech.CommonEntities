using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// OrganizationOrEducationalOrganization MultiType accepts Organization or EducationalOrganization.
    /// </summary>
    [DataContract(Name = "OrganizationOrEducationalOrganization", Namespace = "CommonEntities.MultiType.Alt")]
    public class OrganizationOrEducationalOrganization
    {
        /// <summary>
        /// OrganizationOrEducationalOrganization as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization;

        /// <summary>
        /// OrganizationOrEducationalOrganization as an EducationalOrganization.
        /// </summary>
        [DataMember(Name = "asEducationalOrganization")]
        public EducationalOrganization AsEducationalOrganization;

        /// <summary>
        /// OrganizationOrEducationalOrganization as an Organization.
        /// </summary>
        /// <param name="organization">OrganizationOrEducationalOrganization as an Organization.</param>
        public OrganizationOrEducationalOrganization(Organization organization)
        {
            AsOrganization = organization;
        }

        /// <summary>
        /// OrganizationOrEducationalOrganization as an EducationalOrganization.
        /// </summary>
        /// <param name="educationalOrganization">OrganizationOrEducationalOrganization as an EducationalOrganization.</param>
        public OrganizationOrEducationalOrganization(EducationalOrganization educationalOrganization)
        {
            AsEducationalOrganization = educationalOrganization;
        }

        /// <summary>
        /// OrganizationOrEducationalOrganization.
        /// </summary>
        public OrganizationOrEducationalOrganization() { }
    }
}
