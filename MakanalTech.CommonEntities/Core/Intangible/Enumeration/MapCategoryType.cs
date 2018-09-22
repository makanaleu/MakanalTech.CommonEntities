using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// An enumeration of several kinds of Map.
    /// </summary>
    [DataContract(Name = "MapCategoryType", Namespace = "https://schema.org/MapCategoryType")]
    public enum MapCategoryType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// A parking map.
        /// </summary>
        /// <example>https://schema.org/ParkingMap</example>
        [EnumMember(Value = "ParkingMap")]
        ParkingMap = 10,

        /// <summary>
        /// A seating map.
        /// </summary>
        /// <example>https://schema.org/SeatingMap</example>
        [EnumMember(Value = "SeatingMap")]
        SeatingMap = 20,

        /// <summary>
        /// A transit map.
        /// </summary>
        /// <example>https://schema.org/TransitMap</example>
        [EnumMember(Value = "TransitMap")]
        TransitMap = 30,

        /// <summary>
        /// A venue map (e.g. for malls, auditoriums, museums, etc.).
        /// </summary>
        /// <example>https://schema.org/VenueMap</example>
        [EnumMember(Value = "VenueMap")]
        VenueMap = 40
    }
}
