using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be 
    /// a solo musician.
    /// </summary>
    [DataContract(Name = "MusicGroup", Namespace = "https://schema.org/MusicGroup")]
    public class MusicGroup : PerformingGroup
    {
        /// <summary>
        /// A music album.
        /// </summary>
        /// <example>https://schema.org/album</example>
        [DataMember(Name = "album")]
        public MusicAlbum Album { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        /// <example>https://schema.org/genre</example>
        [DataMember(Name = "genre")]
        public TextRef Genre { get; set; }

        /// <summary>
        /// A music recording (track)—usually a single song. If an ItemList is 
        /// given, the list should contain items of type MusicRecording. 
        /// </summary>
        /// <example>https://schema.org/track</example>
        [DataMember(Name = "track")]
        public MusicRecordingOrItemList Track { get; set; }
    }
}
