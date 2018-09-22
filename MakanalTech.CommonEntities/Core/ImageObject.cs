using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A video file.
    /// </summary>
    [DataContract(Name = "ImageObject", Namespace = "https://schema.org/ImageObject")]
    public class ImageObject : MediaObject
    {
        /// <summary>
        /// The caption for this object. 
        /// </summary>
        /// <example>https://schema.org/caption</example>
        [DataMember(Name = "caption")]
        public Text Caption { get; set; }

        /// <summary>
        /// exif data for this object. 
        /// </summary>
        /// <example>https://schema.org/exifData</example>
        [DataMember(Name = "exifData")]
        public Text ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of 
        /// the page. 
        /// </summary>
        /// <example>https://schema.org/representativeOfPage</example>
        [DataMember(Name = "representativeOfPage")]
        public Boolean RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        /// <example>https://schema.org/thumbnail</example>
        [DataMember(Name = "thumbnail")]
        public ImageObject Thumbnail { get; set; }
    }
}
