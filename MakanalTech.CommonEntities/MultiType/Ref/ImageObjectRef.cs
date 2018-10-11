using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Ref
{
    /// <summary>
    /// ImageObjectRef MultiType accepts ImageObject or URL.
    /// </summary>
    [DataContract(Name = "ImageObjectRef", Namespace = "CommonEntities.MultiType.Ref")]
    public class ImageObjectRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// Image as an ImageObject.
        /// </summary>
        [DataMember(Name = "asImageObject")]
        public ImageObject AsImageObject { get; set; }

        /// <summary>
        /// Image as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl { get; set; }

        /// <summary>
        /// Image as an ImageObject.
        /// </summary>
        /// <param name="imageObject">Image as an ImageObject.</param>
        public ImageObjectRef(ImageObject imageObject)
        {
            AsImageObject = imageObject;
        }

        /// <summary>
        /// Image as a URL.
        /// </summary>
        /// <param name="url">Image as a URL.</param>
        public ImageObjectRef(URL url)
        {
            AsUrl = url;
        }

        /// <summary>
        /// ImageObjectRef.
        /// </summary>
        public ImageObjectRef() { }
    }
}
