using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The human sensory perceptual system or cognitive faculty through which
    /// a person may process or perceive information.
    /// </summary>
    [DataContract(Name = "AccessMode", Namespace = "https://schema.org/accessMode")]
    public enum AccessMode
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Auditory
        /// </summary>
        [EnumMember(Value = "auditory")]
        Auditory = 10,

        /// <summary>
        /// Tactile
        /// </summary>
        [EnumMember(Value = "tactile")]
        Tactile = 20,

        /// <summary>
        /// Textual
        /// </summary>
        [EnumMember(Value = "textual")]
        Textual = 30,

        /// <summary>
        /// Visual
        /// </summary>
        [EnumMember(Value = "visual")]
        Visual = 40,

        /// <summary>
        /// ColorDependent
        /// </summary>
        [EnumMember(Value = "colorDependent")]
        ColorDependent = 50,

        /// <summary>
        /// ChartOnVisual
        /// </summary>
        [EnumMember(Value = "chartOnVisual")]
        ChartOnVisual = 60,

        /// <summary>
        /// ChemOnVisual
        /// </summary>
        [EnumMember(Value = "chemOnVisual")]
        ChemOnVisual = 70,

        /// <summary>
        /// DiagramOnVisual
        /// </summary>
        [EnumMember(Value = "diagramOnVisual")]
        DiagramOnVisual = 80,

        /// <summary>
        /// MathOnVisual
        /// </summary>
        [EnumMember(Value = "mathOnVisual")]
        MathOnVisual = 90,

        /// <summary>
        /// MusicOnVisual
        /// </summary>
        [EnumMember(Value = "musicOnVisual")]
        MusicOnVisual = 100,

        /// <summary>
        /// TextOnVisual
        /// </summary>
        [EnumMember(Value = "textOnVisual")]
        TextOnVisual = 110
    }
}
