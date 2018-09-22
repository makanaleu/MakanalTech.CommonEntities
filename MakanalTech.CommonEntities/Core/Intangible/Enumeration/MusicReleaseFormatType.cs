using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Format of this release (the type of recording media used, ie.
    /// compact disc, digital media, LP, etc.).
    /// </summary>
    [DataContract(Name = "MusicReleaseFormatType", Namespace = "https://schema.org/MusicReleaseFormatType")]
    public enum MusicReleaseFormatType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// CDFormat.
        /// </summary>
        /// <example>https://schema.org/CDFormat</example>
        [EnumMember(Value = "CDFormat")]
        CDFormat = 10,

        /// <summary>
        /// CassetteFormat.
        /// </summary>
        /// <example>https://schema.org/CassetteFormat</example>
        [EnumMember(Value = "CassetteFormat")]
        CassetteFormat = 20,

        /// <summary>
        /// DVDFormat.
        /// </summary>
        /// <example>https://schema.org/DVDFormat</example>
        [EnumMember(Value = "DVDFormat")]
        DVDFormat = 30,

        /// <summary>
        /// DigitalAudioTapeFormat.
        /// </summary>
        /// <example>https://schema.org/DigitalAudioTapeFormat</example>
        [EnumMember(Value = "DigitalAudioTapeFormat")]
        DigitalAudioTapeFormat = 40,

        /// <summary>
        /// DigitalFormat.
        /// </summary>
        /// <example>https://schema.org/DigitalFormat</example>
        [EnumMember(Value = "DigitalFormat")]
        DigitalFormat = 50,

        /// <summary>
        /// LaserDiscFormat.
        /// </summary>
        /// <example>https://schema.org/LaserDiscFormat</example>
        [EnumMember(Value = "LaserDiscFormat")]
        LaserDiscFormat = 60,

        /// <summary>
        /// VinylFormat.
        /// </summary>
        /// <example>https://schema.org/VinylFormat</example>
        [EnumMember(Value = "VinylFormat")]
        VinylFormat = 70
    }
}
