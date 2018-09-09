using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A collection of datasets.
    /// </summary>
    [DataContract(Name = "DataCatalog", Namespace = "https://schema.org/DataCatalog")]
    public class DataCatalog : CreativeWork
    {
        /// <summary>
        /// A dataset contained in this catalog.
        /// </summary>
        /// <example>https://schema.org/dataset</example>
        [DataMember(Name = "dataset")]
        public Dataset Dataset { get; set; }
    }
}
