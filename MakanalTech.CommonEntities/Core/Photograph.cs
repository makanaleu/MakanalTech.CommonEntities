using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A photograph.
    /// </summary>
    [DataContract(Name = "Photograph", Namespace = "https://schema.org/Photograph")]
    public class Photograph : CreativeWork
    {
    }
}
