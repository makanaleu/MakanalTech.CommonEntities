using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Ref
{
    /// <summary>
    /// ImageObjectRef MultiType accepts ImageObject or URL.
    /// </summary>
    [DataContract(Name = "ImageObjectRef", Namespace = "CommonEntities.MultiType.Ref")]
    public class ImageObjectRef
    {
        /// <summary>
        /// Image as an ImageObject.
        /// </summary>
        [DataMember(Name = "asImageObject")]
        public ImageObject AsImageObject;

        /// <summary>
        /// Image as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl;

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
