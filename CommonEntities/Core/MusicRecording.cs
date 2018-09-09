using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    [DataContract(Name = "MusicRecording", Namespace = "https://schema.org/MusicRecording")]
    public class MusicRecording : CreativeWork
    {
        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        /// <example>https://schema.org/byArtist</example>
        [DataMember(Name = "byArtist")]
        public MusicGroup ByArtist { get; set; }

        /// <summary>
        /// The album to which this recording belongs.
        /// </summary>
        /// <example>https://schema.org/inAlbum</example>
        [DataMember(Name = "inAlbum")]
        public MusicAlbum InAlbum { get; set; }

        /// <summary>
        /// The playlist to which this recording belongs.
        /// </summary>
        /// <example>https://schema.org/inPlaylist</example>
        [DataMember(Name = "inPlaylist")]
        public MusicPlaylist InPlaylist { get; set; }

        /// <summary>
        /// The International Standard Recording Code for the recording.
        /// </summary>
        /// <example>https://schema.org/isrcCode</example>
        [DataMember(Name = "isrcCode")]
        public Text IsrcCode { get; set; }

        /// <summary>
        /// The composition this track is a recording of.
        /// </summary>
        /// <seealso cref="MusicComposition.RecordedAs"/>
        /// <example>https://schema.org/recordingOf</example>
        [DataMember(Name = "recordingOf")]
        public MusicComposition RecordingOf { get; set; }
    }
}
