using CommonEntities.Core.Intangible.Enumeration;
using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    [DataContract(Name = "MusicRelease", Namespace = "https://schema.org/MusicRelease")]
    public class MusicRelease : MusicPlaylist
    {
        /// <summary>
        /// The catalog number for the release.
        /// </summary>
        /// <example>https://schema.org/catalogNumber</example>
        [DataMember(Name = "catalogNumber")]
        public Text CatalogNumber { get; set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist.
        /// For example, Red and Blue is credited to "Stefani Germanotta Band", 
        /// but by Lady Gaga.
        /// </summary>
        /// <example>https://schema.org/creditedTo</example>
        [DataMember(Name = "creditedTo")]
        public OrganizationOrPerson CreditedTo { get; set; }

        /// <summary>
        /// Format of this release (the type of recording media used, ie. 
        /// compact disc, digital media, LP, etc.).
        /// </summary>
        /// <example>https://schema.org/musicReleaseFormat</example>
        [DataMember(Name = "musicReleaseFormat")]
        public MusicReleaseFormatType MusicReleaseFormat { get; set; }

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        /// <example>https://schema.org/recordLabel</example>
        [DataMember(Name = "recordLabel")]
        public Organization RecordLabel { get; set; }

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        /// <seealso cref="MusicAlbum.AlbumRelease"/>
        /// <example>https://schema.org/releaseOf</example>
        [DataMember(Name = "releaseOf")]
        public MusicAlbum ReleaseOf { get; set; }
    }
}
