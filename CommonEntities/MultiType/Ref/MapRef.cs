using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Ref
{
    /// <summary>
    /// MapRef MultiType accepts a Map or URL.
    /// </summary>
    /// <example>https://schema.org/hasMap</example>
    [DataContract(Name = "MapRef", Namespace = "CommonEntities.Multitype.Ref")]
    public class MapRef : URL
    {
        /// <summary>
        /// MapRef as a Map.
        /// </summary>
        [DataMember(Name = "asMap")]
        public Map AsMap;

        /// <summary>
        /// MapRef as a Map.
        /// </summary>
        /// <param name="map">MapRef as a Map.</param>
        public MapRef(Map map) : base(map.Url.AsText)
        {
            AsMap = map;
        }

        /// <summary>
        /// MapRef as a URL.
        /// </summary>
        /// <param name="url">MapRef as a URL.</param>
        public MapRef(URL url) : base(url.AsText) { }

        /// <summary>
        /// MapRef.
        /// </summary>
        public MapRef() : base() { }
    }
}
