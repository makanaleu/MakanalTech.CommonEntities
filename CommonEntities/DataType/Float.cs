using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// Data type: Floating number.
    /// </summary>
    [DataContract(Name = "Float", Namespace = "https://schema.org/Float")]
    public class Float : Number
    {
        /// <summary>
        /// Data type: Floating number.
        /// </summary>
        /// <param name="number">Data type: Floating number.</param>
        public Float(float number) : base(number) { }

        /// <summary>
        /// Float.
        /// </summary>
        public Float() : base() { }
    }
}
