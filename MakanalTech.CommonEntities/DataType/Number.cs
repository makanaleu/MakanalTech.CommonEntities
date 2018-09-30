using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.DataType
{
    /// <summary>
    /// Data type: Number.
    /// </summary>
    [DataContract(Name = "Number", Namespace = "https://schema.org/Number")]
    public class Number : Text
    {
        /// <summary>
        /// Number as a float.
        /// </summary>
        [DataMember(Name = "asFloat")]
        public float AsFloat { get; set; }

        /// <summary>
        /// Number as an integer.
        /// </summary>
        [DataMember(Name = "asInteger")]
        public int AsInteger { get; set; }

        /// <summary>
        /// Sets Number values from float. Floats will be rounded to nearest
        /// whole number to produce Integers.
        /// </summary>
        /// <param name="number">Number as a float.</param>
        public Number(float number) : base(number.ToString("R"))
        {
            AsFloat = number;
            AsInteger = (int)Math.Round(number);
        }

        /// <summary>
        /// Sets Number values from int.
        /// </summary>
        /// <param name="number">Number as an integer.</param>
        public Number(int number) : base(number.ToString())
        {
            AsFloat = number;
            AsInteger = number;
        }

        /// <summary>
        /// Sets Number values from a string.
        /// </summary>
        /// <param name="number">Number as a string.</param>
        public Number(string number) : base(number)
        {

            if (!float.TryParse(number, out float outFloat))
            {
                AsFloat = 0;
            }
            else { AsFloat = outFloat; }
            if (!int.TryParse(number, out int outInteger))
            {
                AsInteger = 0;
            }
            else { AsInteger = outInteger; }
        }

        /// <summary>
        /// Data type: Number.
        /// </summary>
        /// <param name="number">Data type: Number.</param>
        public Number(Number number) : base(number.AsText)
        {
            AsFloat = number.AsFloat;
            AsInteger = number.AsInteger;
        }

        /// <summary>
        /// Number.
        /// </summary>
        public Number() : base() { }
    }
}
