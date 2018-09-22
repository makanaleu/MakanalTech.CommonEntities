using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"),
    /// traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// </summary>
    [DataContract(Name = "ProgramMembership", Namespace = "https://schema.org/ProgramMembership")]
    public class ProgramMembership : Thing
    {
        /// <summary>
        /// The organization (airline, travelers' club, etc.) the membership is
        /// made with.
        /// </summary>
        /// <example>https://schema.org/hostingOrganization</example>
        [DataMember(Name = "hostingOrganization")]
        public Organization HostingOrganization { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations 
        /// can be members of organizations; ProgramMembership is typically for
        /// individuals.
        /// </summary>
        /// <seealso cref="Organization.MemberOf"/>
        /// <seealso cref="Person.MemberOf"/>
        /// <example>https://schema.org/member</example>
        [DataMember(Name = "member")]
        public OrganizationOrPerson Member { get; set; }

        /// <summary>
        /// A unique identifier for the membership.
        /// </summary>
        /// <example>https://schema.org/membershipNumber</example>
        [DataMember(Name = "membershipNumber")]
        public Text MembershipNumber { get; set; }

        /// <summary>
        /// The program providing the membership.
        /// </summary>
        /// <example>https://schema.org/programName</example>
        [DataMember(Name = "programName")]
        public Text ProgramName { get; set; }
    }
}
