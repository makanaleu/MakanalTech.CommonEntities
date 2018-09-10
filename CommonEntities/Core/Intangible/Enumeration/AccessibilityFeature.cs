using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// Content features of the resource, such as accessible media, supported
    /// enhancements for accessibility and alternatives.
    /// </summary>
    /// <remarks>
    /// WebSchemas wiki lists possible values: 
    /// http://www.w3.org/wiki/WebSchemas/Accessibility
    /// </remarks>
    [DataContract(Name = "AccessibilityFeature", Namespace = "https://schema.org/accessibilityFeature")]
    public enum AccessibilityFeature
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Alternative text is provided for visual content (e.g., via the HTML
        /// alt attribute).
        /// </summary>
        [EnumMember(Value = "alternativeText")]
        AlternativeText = 10,

        /// <summary>
        /// The work includes annotations from the author, instructor and/or 
        /// others.
        /// </summary>
        [EnumMember(Value = "annotations")]
        Annotations = 20,

        /// <summary>
        /// Audio descriptions are available (e.g., via an HTML5 track element 
        /// with kind="descriptions").
        /// </summary>
        [EnumMember(Value = "audioDescription")]
        AudioDescription = 30,

        /// <summary>
        /// The work includes bookmarks to facilitate navigation to key points.
        /// </summary>
        [EnumMember(Value = "bookmarks")]
        Bookmarks = 40,

        /// <summary>
        /// The content is in braille format, or alternatives are available in 
        /// braille.
        /// </summary>
        [EnumMember(Value = "braille")]
        Braille = 50,

        /// <summary>
        /// Indicates that synchronized captions are available for audio and 
        /// video content.
        /// </summary>
        [EnumMember(Value = "captions")]
        Captions = 60,

        /// <summary>
        /// Identifies that chemical information is encoded using the ChemML 
        /// markup language.
        /// </summary>
        [EnumMember(Value = "ChemML")]
        ChemML = 70,

        /// <summary>
        /// Textual descriptions of math equations are included, whether in the
        /// alt attribute for image-based equations, using the alttext 
        /// attribute for MathML equations, or by other means.
        /// </summary>
        [EnumMember(Value = "describedMath")]
        DescribedMath = 80,

        /// <summary>
        /// Display properties are controllable by the user. This property can 
        /// be set, for example, if custom CSS style sheets can be applied to 
        /// the content to control the appearance.
        /// </summary>
        [EnumMember(Value = "displayTransformability")]
        DisplayTransformability = 90,

        /// <summary>
        /// Audio content with speech in the foreground meets the contrast 
        /// thresholds set out in 
        /// WCAG Success Criteria 1.4.7.
        /// </summary>
        /// <remarks>
        /// See http://www.w3.org/TR/UNDERSTANDING-WCAG20/visual-audio-contrast-noaudio.html
        /// </remarks>
        [EnumMember(Value = "highContrastAudio")]
        HighContrastAudio = 100,

        /// <summary>
        /// Content meets the visual contrast threshold set out in WCAG Success
        /// Criteria 1.4.6.
        /// </summary>
        /// <remarks>
        /// See http://www.w3.org/TR/UNDERSTANDING-WCAG20/visual-audio-contrast7.html
        /// </remarks>
        [EnumMember(Value = "highContrastDisplay")]
        HighContrastDisplay = 110,

        /// <summary>
        /// The work includes an index to the content.
        /// </summary>
        [EnumMember(Value = "index")]
        Index = 120,

        /// <summary>
        /// The content has been formatted to meet large print guidelines.
        /// </summary>
        /// <seealso cref="DisplayTransformability"/>
        /// <remarks>
        /// The property is not set if the font size can be increased.
        /// See displayTransformability.
        /// </remarks>
        [EnumMember(Value = "largePrint")]
        LargePrint = 130,

        /// <summary>
        /// Identifies that mathematical equations and formulas are encoded 
        /// using the designated markup language.
        /// </summary>
        [EnumMember(Value = "latex")]
        Latex = 140,

        /// <summary>
        /// Descriptions are provided for image-based visual content and/or 
        /// complex structures such as tables, mathematics, diagrams and charts.
        /// </summary>
        [EnumMember(Value = "longDescription")]
        LongDescription = 150,

        /// <summary>
        /// Identifies that mathematical equations and formulas are encoded 
        /// using the designated markup language.
        /// </summary>
        [EnumMember(Value = "MathML")]
        MathML = 160,

        /// <summary>
        /// The work includes equivalent print page numbers. This setting is most 
        /// commonly used with ebooks for which there is a print equivalent.
        /// </summary>
        [EnumMember(Value = "printPageNumbers")]
        PrintPageNumbers = 180,

        /// <summary>
        /// The reading order of the content is clearly defined in the markup 
        /// (e.g., figures, sidebars and other secondary content has been marked
        /// up to allow it to be skipped automatically and/or manually escaped 
        /// from.
        /// </summary>
        [EnumMember(Value = "readingOrder")]
        ReadingOrder = 190,

        /// <summary>
        /// Indicates that ruby annotations are provided in the content. Ruby
        /// annotations are used as pronunciation guides for the logographic 
        /// characters for languages like Chinese or Japanese.
        /// </summary>
        [EnumMember(Value = "rubyAnnotations")]
        RubyAnnotations = 200,

        /// <summary>
        /// Synchronized sign language intepretation is available for audio and
        /// video content.
        /// </summary>
        [EnumMember(Value = "signLanguage")]
        SignLanguage = 210,

        /// <summary>
        /// The use of headings in the work fully and accurately reflects the
        /// document hierarchy, allowing navigation by assistive technologies.
        /// </summary>
        [EnumMember(Value = "structuralNavigation")]
        StructuralNavigation = 220,

        /// <summary>
        /// Describes a resource that offers both audio and text, with 
        /// information that allows them to be rendered simultaneously.
        /// </summary>
        [EnumMember(Value = "synchronizedAudioText")]
        SynchronizedAudioText = 230,

        /// <summary>
        /// The work includes table of contents.
        /// </summary>
        [EnumMember(Value = "tableOfContents")]
        TableOfContents = 240,

        /// <summary>
        /// The structures in a PDF have been tagged to improve the navigation 
        /// of the content.
        /// </summary>
        [EnumMember(Value = "taggedPDF")]
        TaggedPDF = 250,

        /// <summary>
        /// Tactile graphics are provided. For example, as described in the BANA 
        /// Guidelines and Standards for Tactile Graphics.
        /// </summary>
        [EnumMember(Value = "tactileGraphic")]
        TactileGraphic = 260,

        /// <summary>
        /// The content is a tactile 3D object, or the model to generate one
        /// is included.
        /// </summary>
        [EnumMember(Value = "tactileObject")]
        TactileObject = 270,

        /// <summary>
        /// For content with timed interaction, this value indicates that the 
        /// user has the ability to control the timing to meet their needs 
        /// (e.g., pause and reset)
        /// </summary>
        [EnumMember(Value = "timingControl")]
        TimingControl = 280,

        /// <summary>
        /// Indicates that a transcript of the audio content is available.
        /// </summary>
        [EnumMember(Value = "transcript")]
        Transcript = 290,

        /// <summary>
        /// One or more of SSML, PLS lexicons and CSS3 Speech properties 
        /// has been used to enhance text-to-speech playback quality.
        /// </summary>
        [EnumMember(Value = "ttsMarkup")]
        TTSMarkup = 300,

        /// <summary>
        /// No digital rights management or other content restriction protocols
        /// have been applied to the resource.
        /// </summary>
        [EnumMember(Value = "unlocked")]
        Unlocked = 310
    }
}
