using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Combo
{
    /// <summary>
    /// Recipient MultiType accepts Audience, ContactPoint, Organization,
    /// or Person.
    /// </summary>
    /// <example>https://schema.org/recipient</example>
    [DataContract(Name = "Recipient", Namespace = "CommonEntities.MultiType.Combo")]
    public class Recipient
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// Recipient as an Audience.
        /// </summary>
        [DataMember(Name = "asAudience")]
        public Audience AsAudience;

        /// <summary>
        /// Recipient as an ContactPoint.
        /// </summary>
        [DataMember(Name = "asContactPoint")]
        public ContactPoint AsContactPoint;

        /// <summary>
        /// Recipient as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization;

        /// <summary>
        /// Recipient as an Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson;

        /// <summary>
        /// Recipient as an Audience.
        /// </summary>
        /// <param name="audience">Recipient as an Audience.</param>
        public Recipient(Audience audience)
        {
            AsAudience = audience;
        }

        /// <summary>
        /// Recipient as an ContactPoint.
        /// </summary>
        /// <param name="contactPoint">ContactPoint</param>
        public Recipient(ContactPoint contactPoint)
        {
            AsContactPoint = contactPoint;
        }

        /// <summary>
        /// Recipient as an Organization.
        /// </summary>
        /// <param name="organization">Recipient as an Organization.</param>
        public Recipient(Organization organization)
        {
            AsOrganization = organization;
        }

        /// <summary>
        /// Recipient as an Person.
        /// </summary>
        /// <param name="person">Recipient as an Person.</param>
        public Recipient(Person person)
        {
            AsPerson = person;
        }

        /// <summary>
        /// Recipient.
        /// </summary>
        public Recipient() { }
    }
}
