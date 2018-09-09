using System;
using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// Data type: Integer.
    /// </summary>
    [DataContract(Name = "Integer", Namespace = "https://schema.org/Integer")]
    public class Integer : Number
    {
        /// <summary>
        /// Data type: Integer.
        /// </summary>
        /// <param name="number">Data type: Integer.</param>
        public Integer(int number) : base(number)
        {
        }
    }
}
