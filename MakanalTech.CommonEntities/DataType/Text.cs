using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.DataType
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
        public string AsText { get; set; }

        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// Data type: Text
        /// </summary>
        /// <param name="text">Data type: Text</param>
        public Text(string text)
        {
            AsText = text;
        }

        /// <summary>
        /// Text.
        /// </summary>
        public Text() { }
    }
}
