using MakanalTech.CommonEntities.MultiType.Combo;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Listify.Intangible
{
    /// <summary>
    /// Listify Extension of Core.Intangible.ItemList.
    /// </summary>
    /// <remarks>
    /// The listify extension is an extension of items not identified as lists
    /// by the core vocabulary but are more prevelantly used as lists rather
    /// than single elements.
    /// </remarks>
    public class ItemList : Core.Intangible.ItemList
    {
        /// <summary>
        /// Core.Intangible.ItemList.ItemListElement as a list.
        /// </summary>
        [DataMember(Name = "itemListElements")]
        public List<ListItemThingOrText> ItemListElements { get; set; }
    }
}
