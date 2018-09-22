using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.DataType;
using MakanalTech.CommonEntities.Health_Lifesci.Intangible.Enumeration;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType
{
    /// <summary>
    /// Category MultiType accepts PhysicalActivityCategory, Thing, or Text (string).
    /// </summary>
    [DataContract(Name = "Category", Namespace = "CommonEntities.MultiType")]
    public class Category : Text
    {
        /// <summary>
        /// Category as a PhysicalActivityCategory.
        /// </summary>
        [DataMember(Name = "asPhysicalActivityCategory")]
        public PhysicalActivityCategory AsPhysicalActivityCategory;

        /// <summary>
        /// Category as a Thing.
        /// </summary>
        [DataMember(Name = "asThing")]
        public Thing AsThing;

        /// <summary>
        /// Category as a PhysicalActivityCategory.
        /// </summary>
        /// <param name="physicalActivityCategory">Category as a PhysicalActivityCategory.</param>
        public Category(PhysicalActivityCategory physicalActivityCategory) 
            : base(Enum.GetName(typeof(PhysicalActivityCategory), physicalActivityCategory))
        {
            AsPhysicalActivityCategory = physicalActivityCategory;
        }

        /// <summary>
        /// Category as a Thing.
        /// </summary>
        /// <param name="thing">Category as a Thing.</param>
        public Category(Thing thing) : base(thing.Name.AsText)
        {
            AsThing = thing;
        }

        /// <summary>
        /// Category as Text (string).
        /// </summary>
        /// <param name="text">Category as Text (string).</param>
        public Category(string text) : base(text) { }

        /// <summary>
        /// Category.
        /// </summary>
        public Category() : base() { }
    }
}
