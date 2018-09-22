using MakanalTech.CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// A list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    [DataContract(Name = "ListItem", Namespace = "https://schema.org/ListItem")]
    public class ListItem : Thing
    {
        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. 
        /// an 'artist' in a list of 'artists')’.
        /// </summary>
        /// <example>https://schema.org/item</example>
        [DataMember(Name = "item")]
        public Thing Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        /// <example>https://schema.org/nextItem</example>
        [DataMember(Name = "nextItem")]
        public ListItem NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        /// <example>https://schema.org/position</example>
        [DataMember(Name = "position")]
        public TextOrInteger Position { get; set; }
    }
}
