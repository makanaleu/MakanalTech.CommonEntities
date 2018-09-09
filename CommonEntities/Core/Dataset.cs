using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    [DataContract(Name = "Dataset", Namespace = "https://schema.org/Dataset")]
    public class Dataset : CreativeWork
    {
        /// <summary>
        /// A downloadable form of this dataset, at a specific location, in a
        /// specific format.
        /// </summary>
        /// <example>https://schema.org/distribution</example>
        [DataMember(Name = "distribution")]
        public DataDownload Distribution { get; set; }

        /// <summary>
        /// A data catalog which contains this dataset.
        /// </summary>
        /// <example>https://schema.org/includedInDataCatalog</example>
        [DataMember(Name = "includedInDataCatalog")]
        public DataCatalog IncludedInDataCatalog { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies 
        /// this serial publication. You can repeat this property to identify 
        /// different formats of, or the linking ISSN (ISSN-L) for, this serial
        /// publication.
        /// </summary>
        /// <example>https://schema.org/issn</example>
        [DataMember(Name = "issn")]
        public Text Issn { get; set; }
    }
}
