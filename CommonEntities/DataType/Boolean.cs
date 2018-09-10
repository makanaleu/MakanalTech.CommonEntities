using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// Boolean: True or False.
    /// </summary>
    [DataContract(Name = "Boolean", Namespace = "https://schema.org/Boolean")]
    public class Boolean : Text
    {
        /// <summary>
        /// Boolean: true or false.
        /// </summary>
        [DataMember(Name = "asBool")]
        public bool AsBool;

        /// <summary>
        /// Boolean: true or false.
        /// </summary>
        /// <param name="value">Boolean: true or false.</param>
        public Boolean(bool value) : base((value == true) ? "True" : "False")
        {
            AsBool = value;
        }

        /// <summary>
        /// Boolean: True or False.
        /// </summary>
        /// <param name="text">Boolean: True or False.</param>
        public Boolean(string text) : base((text == "True") ? "True" : "False")
        {
            AsBool = (text == "True") ? true : false;
        }

        /// <summary>
        /// Boolean: True or False.
        /// </summary>
        /// <param name="value">Boolean as Boolean</param>
        public Boolean(Boolean value) : base(value.AsText)
        {
            AsBool = value.AsBool;
        }
    }
}
