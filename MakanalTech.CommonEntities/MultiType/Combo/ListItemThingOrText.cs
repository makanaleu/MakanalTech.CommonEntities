using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Combo
{
    /// <summary>
    /// ListItemThingOrText MultiType accepts a ListItem, Thing, or Text (string).
    /// </summary>
    /// <example>https://schema.org/itemListElement</example>
    [DataContract(Name = "ListItemThingOrText", Namespace = "CommonEntities.MultiType.Combo")]
    public class ListItemThingOrText : Text
    {
        /// <summary>
        /// ListItemThingOrText as a ListItem.
        /// </summary>
        [DataMember(Name = "asListItem")]
        public ListItem AsListItem { get; set; }

        /// <summary>
        /// ListItemThingOrText as a Thing.
        /// </summary>
        [DataMember(Name = "asThing")]
        public Thing AsThing { get; set; }

        /// <summary>
        /// ListItemThingOrText as a ListItem.
        /// </summary>
        /// <param name="listItem">ListItemThingOrText as a ListItem.</param>
        public ListItemThingOrText(ListItem listItem) 
            : base(listItem.Name.AsText)
        {
            AsListItem = listItem;
        }

        /// <summary>
        /// ListItemThingOrText as a Thing.
        /// </summary>
        /// <param name="thing">ListItemThingOrText as a Thing.</param>
        public ListItemThingOrText(Thing thing) : base(thing.Name.AsText)
        {
            AsThing = thing;
        }

        /// <summary>
        /// ListItemThingOrText as Text (string).
        /// </summary>
        /// <param name="text">ListItemThingOrText as Text (string).</param>
        public ListItemThingOrText(string text) : base(text) { }

        /// <summary>
        /// ListItemThingOrText.
        /// </summary>
        public ListItemThingOrText() : base() { }
    }
}
