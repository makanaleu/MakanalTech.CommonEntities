﻿using MakanalTech.CommonEntities.Core;
using System;
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
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// OrganizationOrEducationalOrganization as an Organization.
        /// </summary>
        [DataMember(Name = "asOrganization")]
        public Organization AsOrganization { get; set; }

        /// <summary>
        /// OrganizationOrEducationalOrganization as an EducationalOrganization.
        /// </summary>
        [DataMember(Name = "asEducationalOrganization")]
        public EducationalOrganization AsEducationalOrganization { get; set; }

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
