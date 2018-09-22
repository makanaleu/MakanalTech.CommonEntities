using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// AnswerOrItemList MultiType accepts either an Answer or ItemList.
    /// </summary>
    /// <example>https://schema.org/track</example>
    [DataContract(Name = "MusicRecordingOrItemList", Namespace = "CommonEntities.MultiType.Alt")]
    public class MusicRecordingOrItemList
    {
        /// <summary>
        /// MusicRecordingOrItemList as a MusicRecording.
        /// </summary>
        [DataMember(Name = "asMusicRecording")]
        public MusicRecording AsMusicRecording;

        /// <summary>
        /// MusicRecordingOrItemList as a ItemList.
        /// </summary>
        [DataMember(Name = "asItemList")]
        public ItemList AsItemList;

        /// <summary>
        /// MusicRecordingOrItemList as a MusicRecording.
        /// </summary>
        /// <param name="musicRecording">MusicRecordingOrItemList as a MusicRecording.</param>
        public MusicRecordingOrItemList(MusicRecording musicRecording)
        {
            AsMusicRecording = musicRecording;
        }

        /// <summary>
        /// MusicRecordingOrItemList as a ItemList.
        /// </summary>
        /// <param name="itemList">MusicRecordingOrItemList as a ItemList.</param>
        public MusicRecordingOrItemList(ItemList itemList)
        {
            AsItemList = itemList;
        }

        /// <summary>
        /// MusicRecordingOrItemList.
        /// </summary>
        public MusicRecordingOrItemList() { }
    }
}
