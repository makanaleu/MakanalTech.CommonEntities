using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A map.
    /// </summary>
    [DataContract(Name = "Map", Namespace = "https://schema.org/Map")]
    public class Map : CreativeWork
    {
        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        /// <example>https://schema.org/mapType</example>
        [DataMember(Name = "mapType")]
        public MapCategoryType MapType { get; set; }
    }
}
