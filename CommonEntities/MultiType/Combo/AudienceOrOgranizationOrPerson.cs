﻿using CommonEntities.Core;
using CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Combo
{
    /// <summary>
    /// AudienceOrOgranizationOrPerson MultiType accepts Audience,
    /// Organization, or Person.
    /// </summary>
    /// <example>https://schema.org/sender</example>
    [DataContract(Name = "AudienceOrOgranizationOrPerson", Namespace = "CommonEntities.MultiType.Combo")]
    public class AudienceOrOgranizationOrPerson
    {
        /// <summary>
        /// AudienceOrOgranizationOrPerson as an Audience.
        /// </summary>
        [DataMember(Name = "asAudience")]
        public Audience AsAudience;

        /// <summary>
        /// AudienceOrOgranizationOrPerson as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization;

        /// <summary>
        /// AudienceOrOgranizationOrPerson as a Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson;

        /// <summary>
        /// AudienceOrOgranizationOrPerson as an Audience.
        /// </summary>
        /// <param name="audience">AudienceOrOgranizationOrPerson as an Audience.</param>
        public AudienceOrOgranizationOrPerson(Audience audience)
        {
            AsAudience = audience;
        }

        /// <summary>
        /// AudienceOrOgranizationOrPerson as an Organization.
        /// </summary>
        /// <param name="organization">AudienceOrOgranizationOrPerson as an Organization.</param>
        public AudienceOrOgranizationOrPerson(Organization organization)
        {
            AsOrganization = organization;
        }

        /// <summary>
        /// AudienceOrOgranizationOrPerson as a Person.
        /// </summary>
        /// <param name="person">AudienceOrOgranizationOrPerson as a Person.</param>
        public AudienceOrOgranizationOrPerson(Person person)
        {
            AsPerson = person;
        }
    }
}