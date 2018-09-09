using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Ref
{
    /// <summary>
    /// CreativeWorkRef MultiType accepts CreativeWork or URL.
    /// </summary>
    [DataContract(Name = "CreativeWorkRef", Namespace = "CommonEntities.MultiType.Ref")]
    public class CreativeWorkRef
    {
        /// <summary>
        /// CreativeWorkRef as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork;

        /// <summary>
        /// CreativeWorkRef as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl;

        /// <summary>
        /// CreativeWorkRef as a CreativeWork.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkRef as a CreativeWork.</param>
        public CreativeWorkRef(CreativeWork creativeWork)
        {
            AsCreativeWork = creativeWork;
        }

        /// <summary>
        /// CreativeWorkRef as a URL.
        /// </summary>
        /// <param name="url">CreativeWorkRef as a URL.</param>
        public CreativeWorkRef(URL url)
        {
            AsUrl = url;
        }
    }
}
