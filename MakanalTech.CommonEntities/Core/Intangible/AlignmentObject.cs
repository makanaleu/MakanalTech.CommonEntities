using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// An intangible item that describes an alignment between a learning 
    /// resource and a node in an educational framework.
    /// </summary>
    [DataContract(Name = "AlignmentObject", Namespace = "https://schema.org/AlignmentObject")]
    public class AlignmentObject : Thing
    {
        /// <summary>
        /// A category of alignment between the learning resource and the 
        /// framework node. Recommended values include: 'assesses', 'teaches',
        /// 'requires', 'textComplexity', 'readingLevel', 'educationalSubject',
        /// and 'educationalLevel'.
        /// </summary>
        /// <example>https://schema.org/alignmentType</example>
        [DataMember(Name = "alignmentType")]
        public Text AlignmentType { get; set; }

        /// <summary>
        /// The framework to which the resource being described is aligned.
        /// </summary>
        /// <example>https://schema.org/educationalFramework</example>
        [DataMember(Name = "educationalFramework")]
        public Text EducationalFramework { get; set; }

        /// <summary>
        /// The description of a node in an established educational framework.
        /// </summary>
        /// <example>https://schema.org/targetDescription</example>
        [DataMember(Name = "targetDescription")]
        public Text TargetDescription { get; set; }

        /// <summary>
        /// The name of a node in an established educational framework.
        /// </summary>
        /// <example>https://schema.org/targetName</example>
        [DataMember(Name = "targetName")]
        public Text TargetName { get; set; }

        /// <summary>
        /// The URL of a node in an established educational framework.
        /// </summary>
        /// <example>https://schema.org/targetUrl</example>
        [DataMember(Name = "targetUrl")]
        public Text TargetUrl { get; set; }
    }
}
