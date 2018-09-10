using System;
using System.Runtime.Serialization;

namespace CommonEntities.DataType
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
        public float AsFloat;

        /// <summary>
        /// Number as an integer.
        /// </summary>
        [DataMember(Name = "asInteger")]
        public int AsInteger;

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
            if (!float.TryParse(number, out AsFloat)) { AsFloat = 0; }
            if (!int.TryParse(number, out AsInteger)) { AsInteger = 0; }
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
        public Number(): base() { }
    }
}
