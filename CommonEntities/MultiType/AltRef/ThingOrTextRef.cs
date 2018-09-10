using CommonEntities.Core;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.AltRef
{
    /// <summary>
    /// ThingOrTextRef MultiType accepts either Thing or TextRef.
    /// </summary>
    [DataContract(Name = "ThingOrTextRef", Namespace = "CommonEntities.MultiType.AltRef")]
    public class ThingOrTextRef
    {
        /// <summary>
        /// ThingOrTextRef as a Thing.
        /// </summary>
        [DataMember(Name = "asThing")]
        public Thing AsThing;

        /// <summary>
        /// ThingOrTextRef as a TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef;

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
