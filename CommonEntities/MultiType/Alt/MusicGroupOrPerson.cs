using CommonEntities.Core;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// MusicGroupOrPerson MultiType accepts either MusicGroup or Person.
    /// </summary>
    [DataContract(Name = "MusicGroupOrPerson", Namespace = "CommonEntities.MultiType.Alt")]
    public class MusicGroupOrPerson
    {
        /// <summary>
        /// MusicGroupOrPerson as a MusicGroup.
        /// </summary>
        [DataMember(Name = "asMusicGroup")]
        public MusicGroup AsMusicGroup;

        /// <summary>
        /// MusicGroupOrPerson as a Person.
        /// </summary>
        [DataMember(Name = "asPerson")]
        public Person AsPerson;

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
