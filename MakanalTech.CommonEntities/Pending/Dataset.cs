using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.Dataset.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Dataset", Namespace = "https://pending.schema.org/Dataset")]
    public class Dataset : Core.Dataset
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

        /// <summary>
        /// The variableMeasured property can indicate (repeated as necessary) 
        /// the variables that are measured in some dataset, either described 
        /// as text or as pairs of identifier and description using PropertyValue. 
        /// </summary>
        /// <example>https://pending.schema.org/variableMeasured</example>
        [DataMember(Name = "variableMeasured")]
        public PropertyValueOrText VariableMeasured { get; set; }
    }
}
