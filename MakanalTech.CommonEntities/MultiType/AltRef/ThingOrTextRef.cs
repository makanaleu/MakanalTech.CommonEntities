using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.MultiType.Ref;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// ThingOrTextRef MultiType accepts either Thing or TextRef.
    /// </summary>
    [DataContract(Name = "ThingOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class ThingOrTextRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// ThingOrTextRef as a Thing.
        /// </summary>
        [DataMember(Name = "asThing")]
        public Thing AsThing { get; set; }

        /// <summary>
        /// ThingOrTextRef as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef { get; set; }

        /// <summary>
        /// ThingOrTextRef as a Thing.
        /// </summary>
        /// <param name="thing">ThingOrTextRef as a Thing.</param>
        public ThingOrTextRef(Thing thing)
        {
            AsThing = thing;
        }

        /// <summary>
        /// ThingOrTextRef as a TextRef.
        /// </summary>
        /// <param name="textRef">ThingOrTextRef as a TextRef.</param>
        public ThingOrTextRef(TextRef textRef)
        {
            AsTextRef = textRef;
        }

        /// <summary>
        /// ThingOrTextRef.
        /// </summary>
        public ThingOrTextRef() { }
    }
}
