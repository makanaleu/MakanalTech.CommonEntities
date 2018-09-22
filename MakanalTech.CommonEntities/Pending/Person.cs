using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.AltRef;
using MakanalTech.CommonEntities.Pending.Intangible;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.Person.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Person", Namespace = "https://pending.schema.org/Person")]
    public class Person
    {
        /// <summary>
        /// The Person's occupation.
        /// </summary>
        /// <remarks>
        /// For past professions, use Role for expressing dates.
        /// </remarks>
        /// <example>https://pending.schema.org/hasOccupation</example>
        [DataMember(Name = "hasOccupation")]
        public Occupation HasOccupation { get; set; }

        /// <summary>
        /// Of a Person, and less typically of an Organization, to indicate a
        /// topic that is known about - suggesting possible expertise but not 
        /// implying it.
        /// </summary>
        /// <remarks>
        /// We do not distinguish skill levels here, or yet relate this to 
        /// educational content, events, objectives or JobPosting descriptions.
        /// </remarks>
        /// <example>https://pending.schema.org/knowsAbout</example>
        [DataMember(Name = "knowsAbout")]
        public List<ThingOrTextRef> KnowsAbout { get; set; }

        /// <summary>
        /// Of a Person, and less typically of an Organization, to indicate a 
        /// known language. 
        /// </summary>
        /// <remarks>
        /// We do not distinguish skill levels or reading/writing/speaking/signing
        /// here. Use language codes from the IETF BCP 47 standard.
        /// See http://tools.ietf.org/html/bcp47.
        /// </remarks>
        /// <example>https://pending.schema.org/knowsLanguage</example>
        [DataMember(Name = "knowsLanguage")]
        public List<LanguageOrText> KnowsLanguage { get; set; }
    }
}
