using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Ref
{
    /// <summary>
    /// PersonRef MultiType accepts Person or URL.
    /// </summary>
    [DataContract(Name = "PersonRef", Namespace = "CommonEntities.MultiType.Ref")]
    public class PersonRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string? ApplicationKey { get; set; }

        /// <summary>
        /// PersonRef as a Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson { get; set; }

        /// <summary>
        /// PersonRef as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl { get; set; }

        /// <summary>
        /// PersonRef as a Person.
        /// </summary>
        /// <param name="person">PersonRef as a Person.</param>
        public PersonRef(Person person)
        {
            AsPerson = person;
        }

        /// <summary>
        /// PersonRef as a URL.
        /// </summary>
        /// <param name="url">PersonRef as a URL.</param>
        public PersonRef(URL url)
        {
            AsUrl = url;
        }

        /// <summary>
        /// PersonRef.
        /// </summary>
        public PersonRef() { }
    }
}
