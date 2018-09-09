using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.DataDownload.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Article", Namespace = "https://pending.schema.org/Article")]
    public class DataDownload : Core.DataDownload
    {
        /// <summary>
        /// A technique or technology used in a Dataset (or DataDownload, 
        /// DataCatalog), corresponding to the method used for measuring the 
        /// corresponding variable(s) (described using variableMeasured). 
        /// </summary>
        /// <remarks>
        /// This is oriented towards scientific and scholarly dataset 
        /// publication but may have broader applicability; it is not intended
        /// as a full representation of measurement, but rather as a high level
        /// summary for dataset discovery.
        /// </remarks>
        /// <example>https://pending.schema.org/measurementTechnique</example>
        [DataMember(Name = "measurementTechnique")]
        public TextRef MeasurementTechnique { get; set; }
    }
}
