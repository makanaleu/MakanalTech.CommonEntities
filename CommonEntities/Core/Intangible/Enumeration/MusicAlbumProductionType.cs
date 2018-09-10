using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live
    /// album, studio album, etc.
    /// </summary>
    /// <remarks>
    /// This vocabulary was improved through collaboration with the MusicBrainz
    /// project (www.musicbrainz.org), and is partially inspired by the 
    /// MusicBrainz and Music Ontology schemas.
    /// </remarks>
    [DataContract(Name = "MusicAlbumProductionType", Namespace = "https://schema.org/MusicAlbumProductionType")]
    public enum  MusicAlbumProductionType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// CompilationAlbum.
        /// </summary>
        /// <example>https://schema.org/CompilationAlbum</example>
        [EnumMember(Value = "CompilationAlbum")]
        CompilationAlbum = 10,

        /// <summary>
        /// DJMixAlbum.
        /// </summary>
        /// <example>https://schema.org/DJMixAlbum</example>
        [EnumMember(Value = "DJMixAlbum")]
        DJMixAlbum = 20,

        /// <summary>
        /// DemoAlbum.
        /// </summary>
        /// <example>https://schema.org/DemoAlbum</example>
        [EnumMember(Value = "DemoAlbum")]
        DemoAlbum = 30,

        /// <summary>
        /// LiveAlbum.
        /// </summary>
        /// <example>https://schema.org/LiveAlbum</example>
        [EnumMember(Value = "LiveAlbum")]
        LiveAlbum = 40,

        /// <summary>
        /// MixtapeAlbum.
        /// </summary>
        /// <example>https://schema.org/MixtapeAlbum</example>
        [EnumMember(Value = "MixtapeAlbum")]
        MixtapeAlbum = 50,

        /// <summary>
        /// RemixAlbum.
        /// </summary>
        /// <example>https://schema.org/RemixAlbum</example>
        [EnumMember(Value = "RemixAlbum")]
        RemixAlbum = 60,

        /// <summary>
        /// SoundtrackAlbum.
        /// </summary>
        /// <example>https://schema.org/SoundtrackAlbum</example>
        [EnumMember(Value = "SoundtrackAlbum")]
        SoundtrackAlbum = 70,

        /// <summary>
        /// SpokenWordAlbum.
        /// </summary>
        /// <example>https://schema.org/SpokenWordAlbum</example>
        [EnumMember(Value = "SpokenWordAlbum")]
        SpokenWordAlbum = 80,

        /// <summary>
        /// StudioAlbum.
        /// </summary>
        /// <example>https://schema.org/StudioAlbum</example>
        [EnumMember(Value = "StudioAlbum")]
        StudioAlbum = 90
    }
}
