using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// An educational organization.
    /// </summary>
    [DataContract(Name = "EducationalOrganization", Namespace = "https://schema.org/EducationalOrganization")]
    public class EducationalOrganization : Organization
    {
    }
}
