using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.AltRef;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    [DataContract(Name = "Thing", Namespace = "https://www.schema.org/Thing")]
    public class Thing
    {
        /// <summary>
        /// An additional type for the item, typically used for adding more 
        /// specific types from external vocabularies in microdata syntax. This
        /// is a relationship between something and a class tha the thing is in.
        /// </summary>
        /// <example>https://www.schema.org/additionalType</example>
        [DataMember(Name = "additionalType")]
        public URL AdditionalType { get; set; }

        /// <summary>
        /// An alias for the item.
        /// </summary>
        /// <example>https://www.schema.org/alternateName</example>
        [DataMember(Name = "alternateName")]
        public Text AlternateName { get; set; }

        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// A description of the item.
        /// </summary>
        /// <example>https://www.schema.org/description</example>
        [DataMember(Name = "description")]
        public Text Description { get; set; }

        /// <summary>
        /// A sub property of description. A short description of them used to 
        /// disambiguate from other similar items.
        /// </summary>
        /// <example>https://www.schema.org/disambiguationDescription</example>
        [DataMember(Name = "disambiguationDescription")]
        public Text DisambiguatingDescription { get; set; }

        /// <summary>
        /// The identifier property represents any kind of identifier for any 
        /// kind of Thing, such as ISBNs, GTIN codes,
        /// UUIDs.
        /// </summary>
        /// <example>https://www.schema.org/identifier</example>
        [DataMember(Name = "identifier")]
        public PropertyValueOrTextRef Identifier { get; set; }

        /// <summary>
        /// An image of the item. This can be a URL or full described 
        /// ImageObject.
        /// </summary>
        /// <example>https://www.schema.org/image</example>
        [DataMember(Name = "image")]
        public ImageObjectRef Image { get; set; }

        /// <summary>
        /// Indicates a page (or other CreativeWork) in which this thing is the
        /// main entity being described.
        /// </summary>
        /// <example>https://www.schema.org/mainEntityOfPage</example>
        [DataMember(Name = "mainEntityOfPage")]
        public CreativeWorkRef MainEntityOfPage { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        /// <example>https://www.schema.org/name</example>
        [DataMember(Name = "name")]
        public Text Name { get; set; }

        /// <summary>
        /// Indicates a potential Action, which describes an idealized action 
        /// in which this Thing would play an 'object' role.
        /// </summary>
        /// <example>https://schema.org/potentialAction</example>
        [DataMember(Name = "potentialAction")]
        public Action PotentialAction { get; set; }

        /// <summary>
        /// URL of a reference Web page that unambiguously indicates the 
        /// Thing's identity (i.e. a Wiki link or official website link).
        /// </summary>
        /// <example>https://www.schema.org/sameAs</example>
        [DataMember(Name = "sameAs")]
        public URL SameAs { get; set; }

        /// <summary>
        /// A CreativeWork or Event about this Thing.
        /// </summary>
        /// <example>https://pending.schema.org/subjectOf</example>
        [DataMember(Name = "subjectOf")]
        public CreativeWorkOrEvent SubjectOf { get; set; }

        /// <summary>
        /// URL of the item.
        /// </summary>
        /// <example>https://www.schema.org/url</example>
        [DataMember(Name = "url")]
        public URL Url { get; set; }
    }
}
