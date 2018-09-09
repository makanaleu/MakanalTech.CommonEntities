using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A photograph.
    /// </summary>
    [DataContract(Name = "Photograph", Namespace = "https://schema.org/Photograph")]
    public class Photograph : CreativeWork
    {
    }
}
