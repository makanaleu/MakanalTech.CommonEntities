using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// A combination of date and time of day in the form 
    /// [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).
    /// </summary>
    [DataContract(Name = "DateTime", Namespace = "https://schema.org/DateTime")]
    public class DateTime : Text
    {
        /// <summary>
        /// DateTime as a Date (when time is not required).
        /// </summary>
        [DataMember(Name = "asDate")]
        public Date AsDate;

        /// <summary>
        /// A combination of date and time of day in the form 
        /// [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).
        /// </summary>
        /// <param name="dateTime">DateTime object.</param>
        public DateTime(System.DateTime dateTime) : base(dateTime.ToString("o"))
        {
            AsDate = new Date(dateTime);
        }
    }
}
