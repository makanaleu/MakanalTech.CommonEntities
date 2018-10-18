using MakanalTech.CommonEntities.Core;
using MakanalTech.CommonEntities.Core.Intangible;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ItemListOrPlace MultiType accepts either an ItemList or Place.
    /// </summary>
    /// <example>https://pending.schema.org/itinerary</example>
    [DataContract(Name = "ItemListOrPlace", Namespace = "CommonEntities.MultiType.Alt")]
    public class ItemListOrPlace
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// ItemListOrPlace as a ItemList.
        /// </summary>
        [DataMember(Name = "asItemList")]
        public ItemList AsItemList { get; set; }

        /// <summary>
        /// ItemListOrPlace as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace { get; set; }

        /// <summary>
        /// ItemListOrPlace as a ItemList.
        /// </summary>
        /// <param name="itemList">ItemListOrPlace as a ItemList.</param>
        public ItemListOrPlace(ItemList itemList)
        {
            AsItemList = itemList;
        }

        /// <summary>
        /// ItemListOrPlace as a Place.
        /// </summary>
        /// <param name="place">ItemListOrPlace as a Place.</param>
        public ItemListOrPlace(Place place)
        {
            AsPlace = place;
        }

        /// <summary>
        /// ItemListOrPlace.
        /// </summary>
        public ItemListOrPlace() { }
    }
}
