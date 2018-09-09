using CommonEntities.DataType;
using System.Runtime.Serialization;
using DateTime = CommonEntities.DataType.DateTime;

namespace CommonEntities.MultiType
{
    /// <summary>
    /// TemporalCoverage MultiType accepts either DateTime, TimePeriod ("2017/2018"), or URL.
    /// </summary>
    /// <remarks>
    /// TimePeriod should follow ISO 8601 time interval format (https://en.wikipedia.org/wiki/ISO_8601#Time_intervals)
    /// </remarks>
    /// <example>https://schema.org/temporalCoverage</example>
    [DataContract(Name = "TemporalCoverage", Namespace = "CommonEntities.MultiType")]
    public class TemporalCoverage : Text
    {
        /// <summary>
        /// TemporalCoverage as a DateTime.
        /// </summary>
        [DataMember(Name = "asDateTime")]
        public DateTime AsDateTime;

        /// <summary>
        /// TemporalCoverage as a TimePeriod.
        /// </summary>
        [DataMember(Name = "asTimePeriod")]
        public Text AsTimePeriod;

        /// <summary>
        /// TemporalCoverage as a URL.
        /// </summary>
        [DataMember(Name = "asUrl")]
        public URL AsUrl;

        /// <summary>
        /// TemporalCoverage as a DateTime.
        /// </summary>
        /// <param name="dateTime">TemporalCoverage as a DateTime.</param>
        public TemporalCoverage(DateTime dateTime) : base(dateTime.AsText)
        {
            AsDateTime = dateTime;
        }

        /// <summary>
        /// TemporalCoverage as an ISO 8601 time interval string.
        /// </summary>
        /// <example>https://en.wikipedia.org/wiki/ISO_8601#Time_intervals</example>
        /// <param name="value">TemporalCoverage as an ISO 8601 time interval string.</param>
        public TemporalCoverage(string text) : base(text)
        {
            AsTimePeriod = new Text(text);
        }

        /// <summary>
        /// TemporalCoverage as a URL.
        /// </summary>
        /// <param name="url">TemporalCoverage as a URL.</param>
        public TemporalCoverage(URL url) : base(url.AsText)
        {
            AsUrl = url;
        }
    }
}
