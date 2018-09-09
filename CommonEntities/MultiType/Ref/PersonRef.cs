using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Ref
{
    /// <summary>
    /// PersonRef MultiType accepts Person or URL.
    /// </summary>
    [DataContract(Name = "PersonRef", Namespace = "CommonEntities.MultiType.Ref")]
    public class PersonRef
    {
        /// <summary>
        /// PersonRef as a Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson;

        /// <summary>
        /// PersonRef as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl;

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
    }
}
