using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// An audio file.
    /// </summary>
    [DataContract(Name = "AudioObject", Namespace = "https://schema.org/AudioObject")]
    public class AudioObject : MediaObject
    {
        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript
        /// of that object.
        /// </summary>
        /// <example>https://schema.org/transcript</example>
        [DataMember(Name = "transcript")]
        public Text Transcript { get; set; }
    }
}
