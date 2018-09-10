using CommonEntities.Core;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// OrganizationOrProgramMembership MultiType accepts Organization or ProgramMembership.
    /// </summary>
    [DataContract(Name = "OrganizationOrProgramMembership", Namespace = "CommonEntities.MultiType.Alt")]
    public class OrganizationOrProgramMembership
    {
        /// <summary>
        /// OrganizationOrProgramMembership as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization;

        /// <summary>
        /// OrganizationOrProgramMembership as a ProgramMembership.
        /// </summary>
        [DataMember(Name = "asProgramMembership")]
        public ProgramMembership AsProgramMembership;

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
