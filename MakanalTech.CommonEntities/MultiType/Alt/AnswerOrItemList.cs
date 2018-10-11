using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// AnswerOrItemList MultiType accepts either an Answer or ItemList.
    /// </summary>
    /// <example>https://schema.org/acceptedAnswer</example>
    [DataContract(Name = "AnswerOrItemList", Namespace = "CommonEntities.MultiType.Alt")]
    public class AnswerOrItemList
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public string ApplicationKey { get; set; }

        /// <summary>
        /// BrandOrOrganization as a Brand.
        /// </summary>
        [DataMember(Name = "asAnswer")]
        public Answer AsAnswer { get; set; }

        /// <summary>
        /// BrandOrOrganization as a Brand.
        /// </summary>
        [DataMember(Name = "asItemList")]
        public ItemList AsItemList { get; set; }

        /// <summary>
        /// BrandOrOrganization as a Brand.
        /// </summary>
        /// <param name="answer">BrandOrOrganization as a Brand.</param>
        public AnswerOrItemList(Answer answer)
        {
            AsAnswer = answer;
        }

        /// <summary>
        /// BrandOrOrganization as a Brand.
        /// </summary>
        /// <param name="itemList">BrandOrOrganization as a Brand.</param>
        public AnswerOrItemList(ItemList itemList)
        {
            AsItemList = itemList;
        }

        /// <summary>
        /// AnswerOrItemList.
        /// </summary>
        public AnswerOrItemList() { }
    }
}
