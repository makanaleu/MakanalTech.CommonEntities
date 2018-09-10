using CommonEntities.Core;
using CommonEntities.Core.Intangible;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Combo
{
    /// <summary>
    /// DataFeedItemThingOrText MultiType accepts DataFeedItem, Thing, or Text.
    /// </summary>
    /// <example>https://schema.org/dataFeedElement</example>
    [DataContract(Name = "DataFeedItemThingOrText", Namespace = "CommonEntities.MultiType.Combo")]
    public class DataFeedItemThingOrText : Text
    {
        /// <summary>
        /// DataFeedItemThingOrText as a DataFeedItem.
        /// </summary>
        [DataMember(Name = "asDataFeedItem")]
        public DataFeedItem AsDataFeedItem;

        /// <summary>
        /// DataFeedItemThingOrText as a Thing.
        /// </summary>
        [DataMember(Name = "asThing")]
        public Thing AsThing;

        /// <summary>
        /// DataFeedItemThingOrText as a DataFeedItem.
        /// </summary>
        /// <param name="dataFeedItem">DataFeedItemThingOrText as a DataFeedItem.</param>
        public DataFeedItemThingOrText(DataFeedItem dataFeedItem) 
            : base(dataFeedItem.Name.AsText)
        {
            AsDataFeedItem = dataFeedItem;
        }

        /// <summary>
        /// DataFeedItemThingOrText as a Thing.
        /// </summary>
        /// <param name="thing">DataFeedItemThingOrText as a Thing.</param>
        public DataFeedItemThingOrText(Thing thing) : base(thing.Name.AsText)
        {
            AsThing = thing;
        }

        /// <summary>
        /// DataFeedItemThingOrText as Text.
        /// </summary>
        /// <param name="text">DataFeedItemThingOrText as Text.</param>
        public DataFeedItemThingOrText(Text text) : base(text.AsText) { }

        /// <summary>
        /// DataFeedItemThingOrText.
        /// </summary>
        public DataFeedItemThingOrText() : base() { }
    }
}
