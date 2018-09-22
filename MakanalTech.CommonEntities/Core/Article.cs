using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// An article, such as a news article or piece of investigative report. 
    /// Newspapers and magazines have articles of many different types and this 
    /// is intended to cover them all.
    /// </summary>
    [DataContract(Name = "Article", Namespace = "https://schema.org/Article")]
    public class Article : CreativeWork
    {
        /// <summary>
        /// The actual body of the article.
        /// </summary>
        /// <example>https://schema.org/articleBody</example>
        [DataMember(Name = "articleBody")]
        public Text ArticleBody { get; set; }

        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or 
        /// newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        /// <example>https://schema.org/articleSection</example>
        [DataMember(Name = "articleSection")]
        public Text ArticleSection { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        /// <example>https://schema.org/pageEnd</example>
        [DataMember(Name = "pageEnd")]
        public Number PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        /// <example>https://schema.org/pageStart</example>
        [DataMember(Name = "pageStart")]
        public Number PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart 
        /// and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        /// <example>https://schema.org/pagination</example>
        [DataMember(Name = "pagination")]
        public Text Pagination { get; set; }

        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        /// <example>https://schema.org/wordCount</example>
        [DataMember(Name = "wordCount")]
        public int WordCount { get; set; }
    }
}
