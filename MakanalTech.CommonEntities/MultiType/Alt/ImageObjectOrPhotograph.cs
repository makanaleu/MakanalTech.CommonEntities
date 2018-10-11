using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ImageObjectOrPhotograph MultiType accepts an ImageObject or Photograph.
    /// </summary>
    /// <example>https://schema.org/photo</example>
    [DataContract(Name = "ImageObjectOrPhotograph", Namespace = "CommonEntities.MultiType.Alt")]
    public class ImageObjectOrPhotograph
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// ImageObjectOrPhotograph as an ImageObject.
        /// </summary>
        [DataMember(Name = "asImageObject")]
        public ImageObject AsImageObject { get; set; }

        /// <summary>
        /// ImageObjectOrPhotograph as a Photograh.
        /// </summary>
        [DataMember(Name = "asPhotograph")]
        public Photograph AsPhotograph { get; set; }

        /// <summary>
        /// ImageObjectOrPhotograph as an ImageObject.
        /// </summary>
        /// <param name="imageObject">ImageObjectOrPhotograph as an ImageObject.</param>
        public ImageObjectOrPhotograph(ImageObject imageObject)
        {
            AsImageObject = imageObject;
        }

        /// <summary>
        /// ImageObjectOrPhotograph as a Photograh.
        /// </summary>
        /// <param name="photograh">ImageObjectOrPhotograph as a Photograh.</param>
        public ImageObjectOrPhotograph(Photograph photograh)
        {
            AsPhotograph = photograh;
        }

        /// <summary>
        /// ImageObjectOrPhotograph.
        /// </summary>
        public ImageObjectOrPhotograph() { }
    }
}
