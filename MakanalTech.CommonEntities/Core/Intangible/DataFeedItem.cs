using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    [DataContract(Name = "DataFeedItem", Namespace = "https://schema.org/DataFeedItem")]
    public class DataFeedItem : Thing
    {
        /// <summary>
        /// The date on which the CreativeWork was created or the item was 
        /// added to a DataFeed.
        /// </summary>
        /// <example>https://schema.org/dateCreated</example>
        [DataMember(Name = "dateCreated")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or
        /// when the item's entry was modified within a DataFeed.
        /// </summary>
        /// <example>https://schema.org/dateDeleted</example>
        [DataMember(Name = "dateDeleted")]
        public DateTime DateDeleted { get; set; }

        /// <summary>
        /// The datetime the item was removed from the DataFeed.
        /// </summary>
        /// <example>https://schema.org/dateModified</example>
        [DataMember(Name = "dateModified")]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an
        /// 'artist' in a list of 'artists')’.
        /// </summary>
        /// <example>https://schema.org/item</example>
        [DataMember(Name = "item")]
        public Thing Item { get; set; }
    }
}
