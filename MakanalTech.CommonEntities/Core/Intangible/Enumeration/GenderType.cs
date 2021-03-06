﻿using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// An enumeration of genders.
    /// </summary>
    [DataContract(Name = "GenderType", Namespace = "https://schema.org/GenderType")]
    public enum GenderType
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// The female gender.
        /// </summary>
        /// <example>https://schema.org/Female</example>
        [EnumMember(Value = "Female")]
        Female = 10,

        /// <summary>
        /// The male gender.
        /// </summary>
        /// <example>https://schema.org/Male</example>
        [EnumMember(Value = "Male")]
        Male = 20
    }
}
