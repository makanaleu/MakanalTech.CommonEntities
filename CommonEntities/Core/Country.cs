using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A country.
    /// </summary>
    [DataContract(Name = "Country", Namespace = "https://schema.org/Country")]
    public class Country : AdministrativeArea
    {
    }
}
