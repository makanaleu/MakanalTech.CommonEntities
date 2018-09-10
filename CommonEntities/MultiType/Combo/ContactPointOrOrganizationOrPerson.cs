using CommonEntities.Core;
using CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Combo
{
    /// <summary>
    /// ContactPointOrOrganizationOrPerson MultiType accepts ContactPoint,
    /// Organization, or Person.
    /// </summary>
    /// <example>https://schema.org/bccRecipient</example>
    [DataContract(Name = "ContactPointOrOrganizationOrPerson", Namespace = "CommonEntities.MultiType.Combo")]
    public class ContactPointOrOrganizationOrPerson
    {
        /// <summary>
        /// ContactPointOrOrganizationOrPerson as a ContactPoint.
        /// </summary>
        [DataMember(Name = "asContactPoint")]
        public ContactPoint AsContactPoint;

        /// <summary>
        /// ContactPointOrOrganizationOrPerson as a Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization;

        /// <summary>
        /// ContactPointOrOrganizationOrPerson as a Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson;

        /// <summary>
        /// ContactPointOrOrganizationOrPerson as a ContactPoint.
        /// </summary>
        /// <param name="contactPoint">ContactPointOrOrganizationOrPerson as a ContactPoint.</param>
        public ContactPointOrOrganizationOrPerson(ContactPoint contactPoint)
        {
            AsContactPoint = contactPoint;
        }

        /// <summary>
        /// ContactPointOrOrganizationOrPerson as a Organization.
        /// </summary>
        /// <param name="organization">ContactPointOrOrganizationOrPerson as a Organization.</param>
        public ContactPointOrOrganizationOrPerson(Organization organization)
        {
            AsOrganization = organization;
        }

        /// <summary>
        /// ContactPointOrOrganizationOrPerson as a Person.
        /// </summary>
        /// <param name="person">ContactPointOrOrganizationOrPerson as a Person.</param>
        public ContactPointOrOrganizationOrPerson(Person person)
        {
            AsPerson = person;
        }

        /// <summary>
        /// ContactPointOrOrganizationOrPerson.
        /// </summary>
        public ContactPointOrOrganizationOrPerson() { }
    }
}
