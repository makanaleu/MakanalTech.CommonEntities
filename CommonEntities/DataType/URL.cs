using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// Data type: URL
    /// </summary>
    [DataContract(Name = "URL", Namespace = "https://schema.org/URL")]
    public class URL : Text
    {
        /// <summary>
        /// Data type: URL
        /// </summary>
        /// <param name="url">Data type: URL</param>
        public URL(string url) : base(url) { }

        /// <summary>
        /// URL.
        /// </summary>
        public URL() : base() { }
    }
}
