using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.DataType
{
    /// <summary>
    /// A date value in ISO 8601 date format. http://en.wikipedia.org/wiki/ISO_8601
    /// </summary>
    [DataContract(Name = "Date", Namespace = "https://schema.org/Date")]
    public class Date : Text
    {
        /// <summary>
        /// A date value in ISO 8601 date format.
        /// </summary>
        /// <param name="dateTime">DateTime object.</param>
        public Date(System.DateTime dateTime) 
            : base(dateTime.ToString("yyyy-MM-dd"))
        {
        }

        /// <summary>
        /// Date.
        /// </summary>
        public Date() : base() { }
    }
}
