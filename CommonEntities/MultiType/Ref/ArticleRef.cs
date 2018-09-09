using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Ref
{
    /// <summary>
    /// ArticleRef MultiType accepts either an Article or URL.
    /// </summary>
    /// <example>https://pending.schema.org/diversityStaffingReport</example>
    [DataContract(Name = "ArticleRef", Namespace = "CommonEntities.Multitype.Ref")]
    public class ArticleRef
    {
        /// <summary>
        /// ArticleRef as an Article.
        /// </summary>
        [DataMember(Name = "asArticle")]
        public Article AsArticle;

        /// <summary>
        /// ArticleRef as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl;

        /// <summary>
        /// ArticleRef as an Article.
        /// </summary>
        /// <param name="article">ArticleRef as an Article.</param>
        public ArticleRef(Article article)
        {
            AsArticle = article;
        }

        /// <summary>
        /// ArticleRef as a URL.
        /// </summary>
        /// <param name="url">ArticleRef as a URL.</param>
        public ArticleRef(URL url)
        {
            AsUrl = url;
        }
    }
}
