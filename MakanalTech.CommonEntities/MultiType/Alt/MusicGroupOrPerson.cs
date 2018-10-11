using MakanalTech.CommonEntities.Core;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// MusicGroupOrPerson MultiType accepts either MusicGroup or Person.
    /// </summary>
    [DataContract(Name = "MusicGroupOrPerson", Namespace = "CommonEntities.MultiType.Alt")]
    public class MusicGroupOrPerson
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// MusicGroupOrPerson as a MusicGroup.
        /// </summary>
        [DataMember(Name = "asMusicGroup")]
        public MusicGroup AsMusicGroup { get; set; }

        /// <summary>
        /// MusicGroupOrPerson as a Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson { get; set; }

        /// <summary>
        /// MusicGroupOrPerson as a MusicGroup.
        /// </summary>
        /// <param name="musicGroup">MusicGroupOrPerson as a MusicGroup.</param>
        public MusicGroupOrPerson(MusicGroup musicGroup)
        {
            AsMusicGroup = musicGroup;
        }

        /// <summary>
        /// MusicGroupOrPerson as a Person.
        /// </summary>
        /// <param name="person">MusicGroupOrPerson as a Person.</param>
        public MusicGroupOrPerson(Person person)
        {
            AsPerson = person;
        }

        /// <summary>
        /// MusicGroupOrPerson.
        /// </summary>
        public MusicGroupOrPerson() { }
    }
}
