using System.Runtime.Serialization;

namespace CommonEntities.DataType
{
    /// <summary>
    /// DataType: Time
    /// </summary>
    /// <remarks>
    /// A point in time recurring on multiple days in the form hh:mm:ss[Z|(+|-)hh:mm]
    /// 
    /// See http://www.w3.org/TR/xmlschema-2/#time.
    /// </remarks>
    [DataContract(Name = "Time", Namespace = "https://schema.org/Time")]
    public class Time : Text
    {
        /// <summary>
        /// Data type: Time 
        /// </summary>
        /// <param name="time">Data type: Time</param>
        public Time(string time): base(time)
        {
        }
    }
}
