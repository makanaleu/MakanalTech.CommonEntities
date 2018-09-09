using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// Data type: Text.
    /// </summary>
    [DataContract(Name = "Text", Namespace = "https://schema.org/Text")]
    public class Text
    {
        /// <summary>
        /// Data type: Text
        /// </summary>
        [DataMember(Name = "asText")]
        public string AsText;

        /// <summary>
        /// Data type: Text
        /// </summary>
        /// <param name="text">Data type: Text</param>
        public Text(string text)
        {
            AsText = text;
        }
    }
}
