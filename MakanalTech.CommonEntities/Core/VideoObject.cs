using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A video file.
    /// </summary>
    [DataContract(Name = "VideoObject", Namespace = "https://schema.org/VideoObject")]
    public class VideoObject : MediaObject
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an 
        /// event. 
        /// </summary>
        /// <remarks>
        /// Actors can be associated with individual items or with a series, 
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Actors"/>
        /// <example>https://schema.org/actor</example>
        [DataMember(Name = "actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// A list of actors, e.g. in tv, radio, movie, video games etc., or in
        /// an event. 
        /// </summary>
        /// <remarks>
        /// Actors can be associated with individual items or with a series, 
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Actor"/>
        /// <example>https://schema.org/actors</example>
        [DataMember(Name = "actors")]
        public List<Person> Actors { get; set; }

        /// <summary>
        /// The caption for this object. 
        /// </summary>
        /// <example>https://schema.org/caption</example>
        [DataMember(Name = "caption")]
        public Text Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or 
        /// of an event.
        /// </summary>
        /// <remarks>
        /// Directors can be associated with individual items or with a series,
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Directors"/>
        /// <example>https://schema.org/director</example>
        [DataMember(Name = "director")]
        public Person Director { get; set; }

        /// <summary>
        /// A list of directors of e.g. tv, radio, movie, video gaming etc. 
        /// content, or of an event.
        /// </summary>
        /// <remarks>
        /// Directors can be associated with individual items or with a series,
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Director"/>
        /// <example>https://schema.org/directors</example>
        [DataMember(Name = "directors")]
        public List<Person> Directors { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        /// <example>https://schema.org/musicBy</example>
        [DataMember(Name = "musicBy")]
        public MusicGroupOrPerson MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        /// <example>https://schema.org/thumbnail</example>
        [DataMember(Name = "thumbnail")]
        public ImageObject Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript
        /// of that object.
        /// </summary>
        /// <example>https://schema.org/transcript</example>
        [DataMember(Name = "transcript")]
        public Text Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        /// <example>https://schema.org/videoFrameSize</example>
        [DataMember(Name = "videoFrameSize")]
        public Text VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        /// <example>https://schema.org/videoQuality</example>
        [DataMember(Name = "videoQuality")]
        public Text VideoQuality { get; set; }
    }
}
