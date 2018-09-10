using CommonEntities.Core;
using CommonEntities.Core.Intangible;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ItemListOrPlace MultiType accepts either an ItemList or Place.
    /// </summary>
    /// <example>https://pending.schema.org/itinerary</example>
    [DataContract(Name = "ItemListOrPlace", Namespace = "CommonEntities.MultiType.Alt")]
    public class ItemListOrPlace
    {
        /// <summary>
        /// ItemListOrPlace as a ItemList.
        /// </summary>
        [DataMember(Name = "asItemList")]
        public ItemList AsItemList;

        /// <summary>
        /// ItemListOrPlace as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace;

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
