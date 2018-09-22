using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.Health_Lifesci.Intangible.Enumeration;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Combo
{
    /// <summary>
    /// PhysicalActivityCategoryThingOrText MultiType accepts PhysicalActivityCategory, Thing, or Text.
    /// </summary>
    /// <example>https://pending.schema.org/category</example>
    [DataContract(Name = "PhysicalActivityCategoryThingOrText", Namespace = "CommonEntities.MultiType.Combo")]
    public class PhysicalActivityCategoryThingOrText : Text
    {
        /// <summary>
        /// PhysicalActivityCategoryThingOrText as a PhysicalActivityCategory.
        /// </summary>
        [DataMember(Name = "asPhysicalActivityCategory")]
        public PhysicalActivityCategory AsPhysicalActivityCategory;

        /// <summary>
        /// PhysicalActivityCategoryThingOrText as a Thing.
        /// </summary>
        [DataMember(Name = "asThing")]
        public Thing AsThing;

        /// <summary>
        /// PhysicalActivityCategoryThingOrText as a PhysicalActivityCategory.
        /// </summary>
        /// <param name="physicalActivityCategory">PhysicalActivityCategoryThingOrText as a PhysicalActivityCategory.</param>
        public PhysicalActivityCategoryThingOrText(PhysicalActivityCategory physicalActivityCategory) 
            : base(Enum.GetName(typeof(PhysicalActivityCategory), physicalActivityCategory))
        {
            AsPhysicalActivityCategory = physicalActivityCategory;
        }

        /// <summary>
        /// PhysicalActivityCategoryThingOrText as a Thing.
        /// </summary>
        /// <param name="thing">PhysicalActivityCategoryThingOrText as a Thing.</param>
        public PhysicalActivityCategoryThingOrText(Thing thing) 
            : base(thing.Name.AsText)
        {
            AsThing = thing;
        }

        /// <summary>
        /// PhysicalActivityCategoryThingOrText as Text.
        /// </summary>
        /// <param name="text">PhysicalActivityCategoryThingOrText as Text.</param>
        public PhysicalActivityCategoryThingOrText(Text text) 
            : base (text.AsText) { }

        /// <summary>
        /// PhysicalActivityCategoryThingOrText.
        /// </summary>
        public PhysicalActivityCategoryThingOrText() : base() { }
    }
}
