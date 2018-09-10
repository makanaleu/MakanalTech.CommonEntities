using CommonEntities.Core;
using CommonEntities.Core.Intangible;
using CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Combo
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
        /// Recipient as an Audience.
        /// </summary>
        [DataMember(Name = "asContactPoint")]
        public Audience AsAudience;

        /// <summary>
        /// Recipient as an ContactPoint.
        /// </summary>
        [DataMember(Name = "asContactPoint")]
        public ContactPoint AsContactPoint;

        /// <summary>
        /// Recipient as an Organization.
        /// </summary>
        [DataMember(Name = "asContactPoint")]
        public Organization AsOrganization;

        /// <summary>
        /// Recipient as an Person.
        /// </summary>
        [DataMember(Name = "asContactPoint")]
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
    }
}
