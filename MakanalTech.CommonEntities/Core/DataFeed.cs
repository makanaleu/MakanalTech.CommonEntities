using MakanalTech.CommonEntities.MultiType.Combo;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// A single feed providing structured information about one or more 
    /// entities or topics.
    /// </summary>
    [DataContract(Name = "DataFeed", Namespace = "https://schema.org/DataFeed")]
    public class DataFeed : Dataset
    {
        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        /// <example>https://schema.org/dataFeedElement</example>
        [DataMember(Name = "dataFeedElement")]
        public DataFeedItemThingOrText DataFeedElement { get; set; }
    }
}
