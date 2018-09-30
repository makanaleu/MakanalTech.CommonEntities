using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// OrganizationOrPerson MultiType accepts either Person or Organization.
    /// </summary>
    [DataContract(Name = "OrganizationOrPerson", Namespace = "CommonEntities.MultiType.Alt")]
    public class OrganizationOrPerson
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// PersonOrganizationOrPersonOrg as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization;

        /// <summary>
        /// OrganizationOrPerson as a Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson;

        /// <summary>
        /// PersonOrganizationOrPersonOrg as an Organization.
        /// </summary>
        /// <param name="organization">OrganizationOrPerson as an Organization.</param>
        public OrganizationOrPerson(Organization organization)
        {
            AsOrganization = organization;
        }

        /// <summary>
        /// OrganizationOrPerson as a Person.
        /// </summary>
        /// <param name="person">OrganizationOrPerson as a Person.</param>
        public OrganizationOrPerson(Person person)
        {
            AsPerson = person;
        }

        /// <summary>
        /// OrganizationOrPerson.
        /// </summary>
        public OrganizationOrPerson() { }
    }
}
