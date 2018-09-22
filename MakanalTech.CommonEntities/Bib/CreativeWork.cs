using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Bib
{
    /// <summary>
    /// Bibliographic Extension of Core.CreativeWork.
    /// </summary>
    /// <remarks>
    /// The Bibliographic Extension within schema.org defines terms such as
    /// Audiobook, Thesis, ComicStory, and workTranslation.
    /// </remarks>
    /// <example>https://bib.schema.org/CreativeWork</example>
    public class CreativeWork : Core.CreativeWork
    {
        /// <summary>
        /// The publishing division which published the comic.
        /// </summary>
        /// <example>https://bib.schema.org/publisherImprint</example>
        [DataMember(Name = "publisherImprint")]
        public Organization PublisherImprint { get; set; }

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a
        /// translationOf “On the Origin of Species”
        /// </summary>
        /// <seealso cref="WorkTranslation"/>
        /// <example>https://bib.schema.org/translationOfWork</example>
        [DataMember(Name = "translationOfWork")]
        public CreativeWork TranslationOfWork { get; set; }

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 
        /// 西遊記 has an English workTranslation “Journey to the West”, a 
        /// German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese 
        /// translation Tây du ký bình khảo.
        /// </summary>
        /// <seealso cref="TranslationOfWork"/>
        /// <example>https://bib.schema.org/workTranslation</example>
        [DataMember(Name = "workTranslation")]
        public CreativeWork WorkTranslation { get; set; }
    }
}
