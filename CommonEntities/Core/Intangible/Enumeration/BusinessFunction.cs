using System;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The business function specifies the type of activity or access (i.e.,
    /// the bundle of rights) offered by the organization or business person 
    /// through the offer. Typical are sell, rental or lease, maintenance or 
    /// repair, manufacture / produce, recycle / dispose, engineering / 
    /// construction, or installation. Proprietary specifications of access 
    /// rights are also instances of this class.
    /// </summary>
    /// <remarks>
    /// This class is derived from the GoodRelations Vocabulary for E-Commerce,
    /// created by Martin Hepp. GoodRelations is a data model for sharing 
    /// e-commerce data on the Web that can be expressed in a variety of 
    /// syntaxes, including RDFa and HTML5 Microdata. More information about 
    /// GoodRelations can be found at http://purl.org/goodrelations/.
    /// </remarks>
    [DataContract(Name = "BusinessFunction", Namespace = "https://schema.org/BusinessFunction")]
    public enum BusinessFunction
    {
        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity offers
        /// (or seeks) the construction and/or installation of the specified 
        /// gr:ProductOrService at the customer's location.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#ConstructionInstallation</example>
        [EnumMember(Value = "ConstructionInstallation")]
        ConstructionInstallation = 10,

        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity offers
        /// (or seeks) the acceptance of the specified gr:ProductOrService for 
        /// proper disposal, recycling, or any other kind of allowed usages, 
        /// freeing the current owner from all rights and obligations of 
        /// ownership.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Dispose</example>
        [EnumMember(Value = "Dispose")]
        Dispose = 20,

        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity 
        /// offers (or seeks) the temporary right to use the specified 
        /// gr:ProductOrService.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#LeaseOut</example>
        [EnumMember(Value = "LeaseOut")]
        LeaseOut = 30,

        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity offers
        /// (or seeks) typical maintenance tasks for the specified 
        /// gr:ProductOrService. Maintenance tasks are actions that undo or 
        /// compensate for wear or other deterioriation caused by regular usage,
        /// in order to restore the originally intended function of the product,
        /// or to prevent outage or malfunction.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Maintain</example>
        [EnumMember(Value = "Maintain")]
        Maintain = 40,

        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity offers
        /// (or seeks) the respective type of service. 
        /// </summary>
        /// <remarks>
        /// Note: Maintain and Repair are also types of Services. However, 
        /// products and services ontologies often provide classes for tangible
        /// products as well as for types of services. The business function 
        /// gr:ProvideService is to be used with such goods that are services, 
        /// while gr:Maintain and gr:Repair can be used with goods for which 
        /// only the class of product exists in the ontology, but not the 
        /// respective type of service. 
        /// </remarks>
        /// <example>http://purl.org/goodrelations/v1#ProvideService</example>
        [EnumMember(Value = "ProvideService")]
        ProvideService = 50,

        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity offers
        /// (or seeks) the evaluation of the chances for repairing, and, if 
        /// positive, repair of the specified gr:ProductOrService. Repairing
        /// means actions that restore the originally intended function of a 
        /// product that suffers from outage or malfunction.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Repair</example>
        [EnumMember(Value = "Repair")]
        Repair = 60,

        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity offers
        /// to permanently transfer all property rights on the specified 
        /// gr:ProductOrService.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Sell</example>
        [EnumMember(Value = "Sell")]
        Sell = 70,

        /// <summary>
        /// This gr:BusinessFunction indicates that the gr:BusinessEntity is in
        /// general interested in purchasing the specified gr:ProductOrService.
        /// DEPRECATED: Use Seeks instead.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Buy</example>
        [Obsolete("DEPRECATED: Use Seeks instead.")]
        [EnumMember(Value = "Buy")]
        Buy = 80,

        /// <summary>
        /// This links a gr:BusinessEntity to gr:Offering nodes that describe 
        /// what the business entity is interested in (i.e., the buy side). 
        /// If you want to express interest in offering something, use gr:offers
        /// instead. Note that this substitutes the former gr:BusinessFunction
        /// gr:Buy, which is now deprecated.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Seeks</example>
        [EnumMember(Value = "Seeks")]
        Seeks = 90
    }
}
