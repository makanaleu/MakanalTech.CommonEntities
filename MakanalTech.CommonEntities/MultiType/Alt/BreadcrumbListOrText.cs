using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// BreadcrumbListOrText MultiType accepts either a Breadcrumb List or string.
    /// </summary>
    /// <example>https://schema.org/breadcrumb</example>
    [DataContract(Name = "BreadcrumbListOrText", Namespace = "CommonEntities.MultiType.Alt")]
    public class BreadcrumbListOrText : Text
    {
        /// <summary>
        /// BreadcrumbListOrText as a BreadcrumbList.
        /// </summary>
        [DataMember(Name = "asBreadcrumbList")]
        public BreadcrumbList AsBreadcrumbList { get; set; }

        /// <summary>
        /// BreadcrumbListOrText as a BreadcrumbList.
        /// </summary>
        /// <param name="breadcrumbList">BreadcrumbListOrText as a BreadcrumbList.</param>
        public BreadcrumbListOrText(BreadcrumbList breadcrumbList) 
            : base(breadcrumbList.Name.AsText)
        {
            AsBreadcrumbList = breadcrumbList;
        }

        /// <summary>
        /// BreadcrumbListOrText as string.
        /// </summary>
        /// <param name="text">BreadcrumbListOrText as string.</param>
        public BreadcrumbListOrText(string text) : base(text) { }

        /// <summary>
        /// BreadcrumbListOrText.
        /// </summary>
        public BreadcrumbListOrText() : base() { }
    }
}
