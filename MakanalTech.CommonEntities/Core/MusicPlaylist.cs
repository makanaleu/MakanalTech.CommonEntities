using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    [DataContract(Name = "MusicPlaylist", Namespace = "https://schema.org/MusicPlaylist")]
    public class MusicPlaylist : CreativeWork
    {
        /// <summary>
        /// The number of tracks in this album or playlist.
        /// </summary>
        /// <example>https://schema.org/numTracks</example>
        [DataMember(Name = "numTracks")]
        public Integer NumTracks { get; set; }

        /// <summary>
        /// A music recording (track)—usually a single song. If an ItemList 
        /// is given, the list should contain items of type MusicRecording. 
        /// </summary>
        /// <example>https://schema.org/track</example>
        [DataMember(Name = "track")]
        public MusicRecordingOrItemList Track { get; set; }
    }
}
