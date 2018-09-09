using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The day of the week, e.g. used to specify to which day the opening hours
    /// of an OpeningHoursSpecification refer.
    /// </summary>
    /// <remarks>
    /// This class is derived from the GoodRelations Vocabulary for E-Commerce,
    /// created by Martin Hepp. GoodRelations is a data model for sharing 
    /// e-commerce data on the Web that can be expressed in a variety of 
    /// syntaxes, including RDFa and HTML5 Microdata. More information about 
    /// GoodRelations can be found at http://purl.org/goodrelations/.
    /// </remarks>
    [DataContract(Name = "DayOfWeek", Namespace = "https://schema.org/DayOfWeek")]
    public enum DayOfWeek
    {
        /// <summary>
        /// The day of the week between Thursday and Saturday.
        /// </summary>
        /// <example>https://schema.org/Friday</example>
        [EnumMember(Value = "Friday")]
        Friday = 10,

        /// <summary>
        /// The day of the week between Sunday and Tuesday.
        /// </summary>
        /// <example>https://schema.org/Monday</example>
        [EnumMember(Value = "Monday")]
        Monday = 20,

        /// <summary>
        /// This stands for any day that is a public holiday; it is a 
        /// placeholder for all official public holidays in some particular 
        /// location. 
        /// </summary>
        /// <remarks>
        /// While not technically a "day of the week", it can be used with 
        /// OpeningHoursSpecification. In the context of an opening hours 
        /// specification it can be used to indicate opening hours on public 
        /// holidays, overriding general opening hours for the day of the week 
        /// on which a public holiday occurs.
        /// </remarks>
        /// <example>https://schema.org/PublicHolidays</example>
        [EnumMember(Value = "PublicHolidays")]
        PublicHolidays = 30,

        /// <summary>
        /// The day of the week between Friday and Sunday. 
        /// </summary>
        /// <example>https://schema.org/Saturday</example>
        [EnumMember(Value = "Saturday")]
        Saturday = 40,

        /// <summary>
        /// The day of the week between Saturday and Monday. 
        /// </summary>
        /// <example>https://schema.org/Sunday</example>
        [EnumMember(Value = "Sunday")]
        Sunday = 50,

        /// <summary>
        /// The day of the week between Wednesday and Friday.
        /// </summary>
        /// <example>https://schema.org/Thursday</example>
        [EnumMember(Value = "Thursday")]
        Thursday = 60,

        /// <summary>
        /// The day of the week between Monday and Wednesday.
        /// </summary>
        /// <example>https://schema.org/Tuesday</example>
        [EnumMember(Value = "Tuesday")]
        Tuesday = 70,

        /// <summary>
        /// The day of the week between Tuesday and Thursday.
        /// </summary>
        /// <example>https://schema.org/Wednesday</example>
        [EnumMember(Value = "Wednesday")]
        Wednesday = 80,
    }
}
