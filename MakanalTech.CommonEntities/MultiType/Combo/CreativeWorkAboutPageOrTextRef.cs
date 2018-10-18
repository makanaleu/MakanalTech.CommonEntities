using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Combo
{
    /// <summary>
    /// CreativeWorkAboutPageOrTextRef MultiType accepts CreativeWork, AboutPage, or TextRef.
    /// </summary>
    /// <example>https://pending.schema.org/ownershipFundingInfo</example>
    [DataContract(Name = "CreativeWorkAboutPageOrTextRef", Namespace = "CommonEntities.MultiType.Combo")]
    public class CreativeWorkAboutPageOrTextRef
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string? ApplicationKey { get; set; }

        /// <summary>
        /// CreativeWorkAboutPageOrTextRef as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork { get; set; }

        /// <summary>
        /// CreativeWorkAboutPageOrTextRef as an AboutPage.
        /// </summary>
        [DataMember(Name = "asAboutPage")]
        public AboutPage AsAboutPage { get; set; }

        /// <summary>
        /// CreativeWorkAboutPageOrTextRef as TextRef.
        /// </summary>
        [DataMember(Name = "asTextRef")]
        public TextRef AsTextRef { get; set; }

        /// <summary>
        /// CreativeWorkAboutPageOrTextRef as a CreativeWork.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkAboutPageOrTextRef as a CreativeWork.</param>
        public CreativeWorkAboutPageOrTextRef(CreativeWork creativeWork)
        {
            AsCreativeWork = creativeWork;
        }

        /// <summary>
        /// CreativeWorkAboutPageOrTextRef as an AboutPage.
        /// </summary>
        /// <param name="aboutPage">CreativeWorkAboutPageOrTextRef as an AboutPage.</param>
        public CreativeWorkAboutPageOrTextRef(AboutPage aboutPage)
        {
            AsAboutPage = aboutPage;
        }

        /// <summary>
        /// CreativeWorkAboutPageOrTextRef as TextRef.
        /// </summary>
        /// <param name="textRef">CreativeWorkAboutPageOrTextRef as TextRef.</param>
        public CreativeWorkAboutPageOrTextRef(TextRef textRef)
        {
            AsTextRef = textRef;
        }

        /// <summary>
        /// CreativeWorkAboutPageOrTextRef.
        /// </summary>
        public CreativeWorkAboutPageOrTextRef() { }
    }
}
