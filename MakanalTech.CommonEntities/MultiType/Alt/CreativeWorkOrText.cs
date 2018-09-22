using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// CreativeWorkOrText MultiType accepts either CreativeWork or string.
    /// </summary>
    [DataContract(Name = "CreativeWorkOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class CreativeWorkOrText : Text
    {
        /// <summary>
        /// CreativeWorkOrText as a CreativeWork.
        /// </summary>
        [DataMember(Name = "asCreativeWork")]
        public CreativeWork AsCreativeWork;
        
        /// <summary>
        /// CreativeWorkOrText as a CreativeWork.
        /// </summary>
        /// <param name="creativeWork">CreativeWorkOrText as a CreativeWork.</param>
        public CreativeWorkOrText(CreativeWork creativeWork) : base(creativeWork.Text.AsText)
        {
            AsCreativeWork = creativeWork;
        }

        /// <summary>
        /// CreativeWorkOrText as a Text (string).
        /// </summary>
        /// <param name="text">CreativeWorkOrText as a Text (string).</param>
        public CreativeWorkOrText(string text) : base(text) { }

        /// <summary>
        /// CreativeWorkOrText.
        /// </summary>
        public CreativeWorkOrText() : base() { }
    }
}
