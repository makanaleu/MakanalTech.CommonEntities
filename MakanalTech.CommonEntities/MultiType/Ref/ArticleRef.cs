using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Ref
{
    /// <summary>
    /// ArticleRef MultiType accepts either an Article or URL.
    /// </summary>
    /// <example>https://pending.schema.org/diversityStaffingReport</example>
    [DataContract(Name = "ArticleRef", Namespace = "CommonEntities.Multitype.Ref")]
    public class ArticleRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string? ApplicationKey { get; set; }

        /// <summary>
        /// ArticleRef as an Article.
        /// </summary>
        [DataMember(Name = "asArticle")]
        public Article AsArticle { get; set; }

        /// <summary>
        /// ArticleRef as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl { get; set; }

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

        /// <summary>
        /// ArticleRef.
        /// </summary>
        public ArticleRef() { }
    }
}
