using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// </summary>
    /// <remarks>
    /// This vocabulary was improved through collaboration with the MusicBrainz 
    /// project (www.musicbrainz.org), and is partially inspired by the 
    /// MusicBrainz and Music Ontology schemas.
    /// </remarks>
    [DataContract(Name = "MusicAlbumReleaseType", Namespace = "https://schema.org/MusicAlbumReleaseType")]
    public enum MusicAlbumReleaseType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// AlbumRelease.
        /// </summary>
        /// <example>https://schema.org/AlbumRelease</example>
        [EnumMember(Value = "AlbumRelease")]
        AlbumRelease = 10,

        /// <summary>
        /// BroadcastRelease.
        /// </summary>
        /// <example>https://schema.org/BroadcastRelease</example>
        [EnumMember(Value = "BroadcastRelease")]
        BroadcastRelease = 20,

        /// <summary>
        /// EPRelease.
        /// </summary>
        /// <example>https://schema.org/EPRelease</example>
        [EnumMember(Value = "EPRelease")]
        EPRelease = 30,

        /// <summary>
        /// SingleRelease.
        /// </summary>
        /// <example>https://schema.org/SingleRelease</example>
        [EnumMember(Value = "SingleRelease")]
        SingleRelease = 40,
    }
}
