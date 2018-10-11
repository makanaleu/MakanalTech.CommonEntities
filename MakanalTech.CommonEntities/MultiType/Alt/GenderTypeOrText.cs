using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using MakanalTech.CommonEntities.DataType;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// GenderTypeOrText MultiType accepts GenderType or string.
    /// </summary>
    [DataContract(Name = "GenderTypeOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class GenderTypeOrText : Text
    {
        /// <summary>
        /// GenderTypeOrText as a GenderType.
        /// </summary>
        [DataMember(Name = "asGenderType")]
        public GenderType AsGenderType { get; set; }

        /// <summary>
        /// GenderTypeOrText as a GenderType.
        /// </summary>
        /// <param name="genderType">GenderTypeOrText as a GenderType.</param>
        public GenderTypeOrText(GenderType genderType)
            : base(Enum.GetName(typeof(GenderType), genderType))
        {
            AsGenderType = genderType;
        }

        /// <summary>
        /// GenderTypeOrText as string.
        /// </summary>
        /// <param name="text">GenderTypeOrText as string.</param>
        public GenderTypeOrText(string text) : base(text) { }

        /// <summary>
        /// GenderTypeOrText.
        /// </summary>
        public GenderTypeOrText() : base() { }
    }
}
