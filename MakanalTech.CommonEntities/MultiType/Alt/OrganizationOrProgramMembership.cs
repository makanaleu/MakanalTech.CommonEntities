using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// OrganizationOrProgramMembership MultiType accepts Organization or ProgramMembership.
    /// </summary>
    [DataContract(Name = "OrganizationOrProgramMembership", Namespace = "CommonEntities.MultiType.Alt")]
    public class OrganizationOrProgramMembership
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// OrganizationOrProgramMembership as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization { get; set; }

        /// <summary>
        /// OrganizationOrProgramMembership as a ProgramMembership.
        /// </summary>
        [DataMember(Name = "asProgramMembership")]
        public ProgramMembership AsProgramMembership { get; set; }

        /// <summary>
        /// OrganizationOrProgramMembership as an Organization.
        /// </summary>
        /// <param name="organization">OrganizationOrProgramMembership as an Organization.</param>
        public OrganizationOrProgramMembership(Organization organization)
        {
            AsOrganization = organization;
        }

        /// <summary>
        /// OrganizationOrProgramMembership as a ProgramMembership.
        /// </summary>
        /// <param name="programMembership">OrganizationOrProgramMembership as a ProgramMembership.</param>
        public OrganizationOrProgramMembership(ProgramMembership programMembership)
        {
            AsProgramMembership = programMembership;
        }

        /// <summary>
        /// OrganizationOrProgramMembership.
        /// </summary>
        public OrganizationOrProgramMembership() { }
    }
}
