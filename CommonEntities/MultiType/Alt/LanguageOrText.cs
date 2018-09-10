using CommonEntities.Core.Intangible;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// LanguageOrText MultiType accepts either Laguage or string.
    /// </summary>
    [DataContract(Name = "LanguageOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class LanguageOrText : Text
    {
        /// <summary>
        /// LanguageOrText as a Language.
        /// </summary>
        [DataMember(Name = "asLanguage")]
        public Language AsLanguage;

        /// <summary>
        /// LanguageOrText as a Language.
        /// </summary>
        /// <param name="language">LanguageOrText as a Language.</param>
        public LanguageOrText(Language language) : base(language.Name.AsText)
        {
            AsLanguage = language;
        }

        /// <summary>
        /// LanguageOrText as a Text (string).
        /// </summary>
        /// <param name="text">LanguageOrText as a Text (string).</param>
        public LanguageOrText(string text) : base(text) { }

        /// <summary>
        /// LanguageOrText.
        /// </summary>
        public LanguageOrText() : base() { }
    }
}
