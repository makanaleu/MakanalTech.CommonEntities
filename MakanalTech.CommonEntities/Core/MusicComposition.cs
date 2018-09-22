using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A musical composition.
    /// </summary>
    [DataContract(Name = "MusicComposition", Namespace = "https://schema.org/MusicComposition")]
    public class MusicComposition : CreativeWork
    {
        /// <summary>
        /// The person or organization who wrote a composition, or who is the 
        /// composer of a work performed at some event.
        /// </summary>
        /// <example>https://schema.org/composer</example>
        [DataMember(Name = "composer")]
        public OrganizationOrPerson Composer { get; set; }

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        /// <example>https://schema.org/firstPerformance</example>
        [DataMember(Name = "firstPerformance")]
        public Event FirstPerformance { get; set; }

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a 
        /// symphony).
        /// </summary>
        /// <example>https://schema.org/includedComposition</example>
        [DataMember(Name = "includedComposition")]
        public MusicComposition IncludedComposition { get; set; }

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        /// <example>https://schema.org/iswcCode</example>
        [DataMember(Name = "iswcCode")]
        public Text IswcCode { get; set; }

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        /// <example>https://schema.org/lyricist</example>
        [DataMember(Name = "lyricist")]
        public Person Lyricist { get; set; }

        /// <summary>
        /// The words in the song.
        /// </summary>
        /// <example>https://schema.org/lyrics</example>
        [DataMember(Name = "lyrics")]
        public CreativeWork Lyrics { get; set; }

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        /// <example>https://schema.org/musicArrangement</example>
        [DataMember(Name = "musicArrangement")]
        public MusicComposition MusicArrangement { get; set; }

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        /// <example>https://schema.org/musicCompositionForm</example>
        [DataMember(Name = "musicCompositionForm")]
        public Text MusicCompositionForm { get; set; }

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        /// <example>https://schema.org/musicalKey</example>
        [DataMember(Name = "musicalKey")]
        public Text MusicalKey { get; set; }

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        /// <seealso cref="MusicRecording.RecordingOf"/>
        /// <example>https://schema.org/recordedAs</example>
        [DataMember(Name = "recordedAs")]
        public MusicRecording RecordedAs { get; set; }
    }
}
