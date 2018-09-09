using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides 
    /// background context and supporting materials for understanding the news.
    /// </summary>
    [DataContract(Name = "NewsArticle", Namespace = "https://schema.org/NewsArticle")]
    public class NewsArticle : Article
    {
        /// <summary>
        /// A dateline is a brief piece of text included in news articles that 
        /// describes where and when the story was written or filed though the 
        /// date is often omitted. Sometimes only a placename is provided.
        /// </summary>
        /// <example>https://schema.org/dateline</example>
        [DataMember(Name = "dateline")]
        public Text Dateline { get; set; }

        /// <summary>
        /// The number of the column in which the NewsArticle appears in the 
        /// print edition.
        /// </summary>
        /// <example>https://schema.org/printColumn</example>
        [DataMember(Name = "printColumn")]
        public Text PrintColumn { get; set; }

        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        /// <example>https://schema.org/printEdition</example>
        [DataMember(Name = "printEdition")]
        public Text PrintEdition { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name
        /// of the page on which the article is found. Please note that this 
        /// field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        /// <example>https://schema.org/printPage</example>
        [DataMember(Name = "printPage")]
        public Text PrintPage { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the 
        /// print section in which the article appeared.
        /// </summary>
        /// <example>https://schema.org/printSection</example>
        [DataMember(Name = "printSection")]
        public Text PrintSection { get; set; }
    }
}
