using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The human sensory perceptual system or cognitive faculty through which
    /// a person may process or perceive information.
    /// </summary>
    [DataContract(Name = "AccessMode", Namespace = "https://schema.org/accessMode")]
    public enum AccessMode
    {
        [EnumMember(Value = "auditory")]
        Auditory = 10,

        [EnumMember(Value = "tactile")]
        Tactile = 20,

        [EnumMember(Value = "textual")]
        Textual = 30,

        [EnumMember(Value = "visual")]
        Visual = 40,

        [EnumMember(Value = "colorDependent")]
        ColorDependent = 50,

        [EnumMember(Value = "chartOnVisual")]
        ChartOnVisual = 60,

        [EnumMember(Value = "chemOnVisual")]
        ChemOnVisual = 70,

        [EnumMember(Value = "diagramOnVisual")]
        DiagramOnVisual = 80,

        [EnumMember(Value = "mathOnVisual")]
        MathOnVisual = 90,

        [EnumMember(Value = "musicOnVisual")]
        MusicOnVisual = 100,

        [EnumMember(Value = "textOnVisual")]
        TextOnVisual = 110
    }
}
