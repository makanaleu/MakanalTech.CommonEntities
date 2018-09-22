using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// TextOrInteger MultiType accepts Text or Integer DataTypes.
    /// </summary>
    [DataContract(Name = "TextOrInteger", Namespace = "CommonEntities.MultiType.Alt")]
    public class TextOrInteger : Number
    {
        /// <summary>
        /// TextOrInteger as a string.
        /// </summary>
        /// <param name="text">TextOrInteger as a string.</param>
        public TextOrInteger(Text text) : base(text.AsText) { }

        /// <summary>
        /// TextOrInteger as an integer.
        /// </summary>
        /// <param name="number">TextOrInteger as an integer.</param>
        public TextOrInteger(Integer number) : base(number) { }

        /// <summary>
        /// TextOrInteger.
        /// </summary>
        public TextOrInteger() : base() { }
    }
}
