using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible
{
    /// <summary>
    /// An OfferCatalog is an ItemList that contains related Offers and/or 
    /// further OfferCatalogs that are offeredBy the same provider.
    /// </summary>
    [DataContract(Name = "OfferCatalog", Namespace = "https://schema.org/OfferCatalog")]
    public class OfferCatalog : ItemList
    {
    }
}
