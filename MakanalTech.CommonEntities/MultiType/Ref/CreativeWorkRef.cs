using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Ref
{
    /// <summary>
    /// CreativeWorkRef MultiType accepts CreativeWork or URL.
    /// </summary>
    [DataContract(Name = "CreativeWorkRef", Namespace = "CommonEntities.MultiType.Ref")]
    public class CreativeWorkRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// CreativeWorkRef as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork;

        /// <summary>
        /// CreativeWorkRef as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl { get; set; }

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

        /// <summary>
        /// CreativeWorkRef.
        /// </summary>
        public CreativeWorkRef() { }
    }
}
