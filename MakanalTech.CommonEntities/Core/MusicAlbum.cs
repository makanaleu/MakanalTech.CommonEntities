using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    [DataContract(Name = "MusicAlbum", Namespace = "https://schema.org/MusicAlbum")]
    public class MusicAlbum : MusicPlaylist
    {
        /// <summary>
        /// Classification of the album by it's type of content: soundtrack, 
        /// live album, studio album, etc.
        /// </summary>
        /// <example>https://schema.org/albumProductionType</example>
        [DataMember(Name = "albumProductionType")]
        public MusicAlbumProductionType AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        /// <seealso cref="MusicRelease.ReleaseOf"/>
        /// <example>https://schema.org/albumRelease</example>
        [DataMember(Name = "albumRelease")]
        public MusicRelease AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        /// <example>https://schema.org/albumReleaseType</example>
        [DataMember(Name = "albumReleaseType")]
        public MusicAlbumReleaseType AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        /// <example>https://schema.org/byArtist</example>
        [DataMember(Name = "byArtist")]
        public MusicGroup ByArtist { get; set; }
    }
}
