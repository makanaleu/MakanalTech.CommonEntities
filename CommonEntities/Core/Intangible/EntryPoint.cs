using CommonEntities.DataType;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible
{
    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
    [DataContract(Name = "EntryPoint", Namespace = "https://schema.org/EntryPoint")]
    public class EntryPoint : Thing
    {
        /// <summary>
        /// An application that can complete the request.
        /// </summary>
        /// <example>https://schema.org/actionApplication</example>
        [DataMember(Name = "actionApplication")]
        public SoftwareApplication ActionApplication { get; set; }

        /// <summary>
        /// The high level platform(s) where the Action can be performed for 
        /// the given URL. To specify a specific application or operating 
        /// system instance, use actionApplication.
        /// </summary>
        /// <example>https://schema.org/actionPlatform</example>
        [DataMember(Name = "actionPlatform")]
        public TextRef ActionPlatform { get; set; }

        /// <summary>
        /// The supported content type(s) for an EntryPoint response.
        /// </summary>
        /// <example>https://schema.org/contentType</example>
        [DataMember(Name = "contentType")]
        public Text ContentType { get; set; }

        /// <summary>
        /// The supported encoding type(s) for an EntryPoint request.
        /// </summary>
        /// <example>https://schema.org/encodingType</example>
        [DataMember(Name = "encodingType")]
        public Text EncodingType { get; set; }

        /// <summary>
        /// An HTTP method that specifies the appropriate HTTP method for a 
        /// request to an HTTP EntryPoint. Values are capitalized strings
        /// as used in HTTP.
        /// </summary>
        /// <example>https://schema.org/httpMethod</example>
        [DataMember(Name = "httpMethod")]
        public Text HttpMethod { get => HttpMethod; set => value.AsText.ToUpper(); }

        /// <summary>
        /// An url template (RFC6570) that will be used to construct the 
        /// target of the execution of the action.
        /// </summary>
        /// <example>https://schema.org/urlTemplate</example>
        [DataMember(Name = "urlTemplate")]
        public Text UrlTemplate { get; set; }
    }
}
