using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular
    /// government.
    /// </summary>
    [DataContract(Name = "AdministrativeArea", Namespace = "https://schema.org/AdministrativeArea")]
    public class AdministrativeArea : Place
    {
    }
}
