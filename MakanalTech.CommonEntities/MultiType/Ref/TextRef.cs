using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Ref
{
    /// <summary>
    /// TextRef MultiType accepts Text (string) or URL.
    /// </summary>
    [DataContract(Name = "TextRef", Namespace = "CommonEntities.MultiType.Ref")]
    public class TextRef : Text
    {
        /// <summary>
        /// TextRef as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl;

        /// <summary>
        /// TextRef as a Text (string).
        /// </summary>
        /// <param name="text">TextRef as a Text (string).</param>
        public TextRef(string text) : base(text)
        {
            AsText = text;
        }

        /// <summary>
        /// TextRef as a URL.
        /// </summary>
        /// <param name="url">TextRef as a URL.</param>
        public TextRef(URL url) : base(url.AsText)
        {
            AsUrl = url;
        }

        /// <summary>
        /// TextRef.
        /// </summary>
        public TextRef() : base() { }
    }
}
