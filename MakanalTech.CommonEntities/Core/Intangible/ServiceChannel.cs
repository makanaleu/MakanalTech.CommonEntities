using MakanalTech.CommonEntities.Core.Intangible.Quantity;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web
    /// site, or phone number.
    /// </summary>
    [DataContract(Name = "ServiceChannel", Namespace = "https://schema.org/ServiceChannel")]
    public class ServiceChannel : Thing
    {
        /// <summary>
        /// A language someone may use with or at the item, service or place.  
        /// </summary>
        /// <remarks>
        /// Please use one of the language codes from the IETF BCP 47 standard.
        /// See http://tools.ietf.org/html/bcp47.
        /// </remarks>
        /// <example>https://schema.org/availableLanguage</example>
        [DataMember(Name = "availableLanguage")]
        public LanguageOrText AvailableLanguage { get; set; }

        /// <summary>
        /// Estimated processing time for the service using this channel. 
        /// </summary>
        /// <example>https://schema.org/processingTime</example>
        [DataMember(Name = "processingTime")]
        public Duration ProcessingTime { get; set; }

        /// <summary>
        /// The service provided by this channel. 
        /// </summary>
        /// <example>https://schema.org/providesService</example>
        [DataMember(Name = "providesService")]
        public Service ProvidesService { get; set; }

        /// <summary>
        /// The location (e.g. civic structure, local business, etc.) where a 
        /// person can go to access the service.
        /// </summary>
        /// <example>https://schema.org/serviceLocation</example>
        [DataMember(Name = "serviceLocation")]
        public Place ServiceLocation { get; set; }

        /// <summary>
        /// The phone number to use to access the service.
        /// </summary>
        /// <example>https://schema.org/servicePhone</example>
        [DataMember(Name = "servicePhone")]
        public ContactPoint ServicePhone { get; set; }

        /// <summary>
        /// The address for accessing the service by mail.
        /// </summary>
        /// <example>https://schema.org/servicePostalAddress</example>
        [DataMember(Name = "servicePostalAddress")]
        public PostalAddress ServicePostalAddress { get; set; }

        /// <summary>
        /// The number to access the service by text message.
        /// </summary>
        /// <example>https://schema.org/serviceSmsNumber</example>
        [DataMember(Name = "serviceSmsNumber")]
        public ContactPoint ServiceSmsNumber { get; set; }

        /// <summary>
        /// 	The website to access the service.
        /// </summary>
        /// <example>https://schema.org/serviceUrl</example>
        [DataMember(Name = "serviceUrl")]
        public URL ServiceUrl { get; set; }
    }
}
