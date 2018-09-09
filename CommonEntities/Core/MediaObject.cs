using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DateTime = CommonEntities.DataType.DateTime;

namespace CommonEntities.Core
{
    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a 
    /// web page or a downloadable dataset i.e. DataDownload.
    /// </summary>
    /// <remarks>
    /// Note that a creative work may have many media objects associated with 
    /// it on the same web page. For example, a page about a single song 
    /// (MusicRecording) may have a music video (VideoObject), and a high and 
    /// low bandwidth audio stream (2 AudioObject's).
    /// </remarks>
    [DataContract(Name = "MediaObject", Namespace = "https://schema.org/MediaObject")]
    public class MediaObject : CreativeWork
    {
        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        /// <example>https://schema.org/associatedArticle</example>
        [DataMember(Name = "associatedArticle")]
        public NewsArticle AssociatedArticle { get; set; }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        /// <example>https://schema.org/bitrate</example>
        [DataMember(Name = "bitrate")]
        public Text Bitrate { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        /// <example>https://schema.org/contentSize</example>
        [DataMember(Name = "contentSize")]
        public Text ContentSize { get; set; }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or 
        /// video file.
        /// </summary>
        /// <example>https://schema.org/contentUrl</example>
        [DataMember(Name = "contentUrl")]
        public URL ContentUrl { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. 
        /// </summary>
        /// <remarks>
        /// In general, this is the information in the src element of an embed 
        /// tag and should not be the same as the content of the loc tag.
        /// </remarks>
        /// <example>https://schema.org/embedUrl</example>
        [DataMember(Name = "embedUrl")]
        public URL EmbedUrl { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        /// <example>https://schema.org/encodesCreativeWork</example>
        [DataMember(Name = "encodesCreativeWork")]
        public CreativeWork EncodesCreativeWork { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        /// <example>https://schema.org/height</example>
        [DataMember(Name = "height")]
        public QuantitativeValueOrDistance Height { get; set; }

        /// <summary>
        /// Player type required—for example, Flash or Silverlight.
        /// </summary>
        /// <example>https://schema.org/playerType</example>
        [DataMember(Name = "playerType")]
        public QuantitativeValueOrDistance PlayerType { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. 
        /// series, video game, episode etc.
        /// </summary>
        /// <example>https://schema.org/productionCompany</example>
        [DataMember(Name = "productionCompany")]
        public Organization ProductionCompany { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's
        /// assumed to be allowed everywhere.
        /// </summary>
        /// <remarks>
        ///  Specify the countries in ISO 3166 format. 
        ///  See http://en.wikipedia.org/wiki/ISO_3166.
        /// </remarks>
        /// <example>https://schema.org/regionsAllowed</example>
        [DataMember(Name = "regionsAllowed")]
        public List<Place> RegionsAllowed { get; set; }

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        /// <example>https://schema.org/uploadDate</example>
        [DataMember(Name = "uploadDate")]
        public DateTime UploadDate { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        /// <example>https://schema.org/width</example>
        [DataMember(Name = "width")]
        public QuantitativeValueOrDistance Width { get; set; }
    }
}
