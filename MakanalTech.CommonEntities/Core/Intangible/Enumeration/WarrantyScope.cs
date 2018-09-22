using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// A range of of services that will be provided to a customer free of 
    /// charge in case of a defect or malfunction of a product.
    /// </summary>
    /// <remarks>
    /// This class is derived from the GoodRelations Vocabulary for E-Commerce,
    /// created by Martin Hepp. GoodRelations is a data model for sharing 
    /// e-commerce data on the Web that can be expressed in a variety of 
    /// syntaxes, including RDFa and HTML5 Microdata. More information about 
    /// GoodRelations can be found at http://purl.org/goodrelations/.
    /// </remarks>
    [DataContract(Name = "WarrantyScope", Namespace = "https://schema.org/WarrantyScope")]
    public enum WarrantyScope
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// In case of a defect or malfunction, the buying party has the right
        /// to transport the good to a service location determined by the the
        /// selling gr:BusinessEntity and will be charged only for parts and 
        /// materials needed to fix the problem. Labor will be covered by the 
        /// selling business entity or one of its partnering business entities.
        /// </summary>
        /// <remarks>
        /// Note: This is just a rough classification for filtering offers. It 
        /// is up to the buying party to check the exact scope and terms and
        /// conditions of the gr:WarrantyPromise.
        /// </remarks>
        /// <example>http://purl.org/goodrelations/v1#Labor-BringIn</example>
        [EnumMember(Value = "Labor-BringIn")]
        LaborBringIn = 10,

        /// <summary>
        /// In case of a defect or malfunction, the buying party has the right 
        /// to transport the good to a service location determined by the the
        /// selling gr:BusinessEntity and will not be be charged for labor, 
        /// parts, and materials needed to fix the problem. All those costs 
        /// will be covered by the selling business entity or one of its 
        /// partnering business entities.
        /// </summary>
        /// <remarks>
        /// Note: This is just a rough classification for filtering offers. It 
        /// is up to the buying party to check the exact scope and terms and
        /// conditions of the gr:WarrantyPromise.
        /// </remarks>
        /// <example>http://purl.org/goodrelations/v1#PartsAndLabor-BringIn</example>
        [EnumMember(Value = "PartsAndLabor-BringIn")]
        PartsAndLaborBringIn = 20,

        /// <summary>
        /// In case of a defect or malfunction, the buying party has the right
        /// to request from the selling gr:Business Entity to pick-up the good 
        /// from its current location to a suitable service location, where the
        /// functionality of the good will be restored. All transportation, 
        /// labor, parts, and materials needed to fix the problem will be 
        /// covered by the selling business entity or one of its partnering 
        /// business entities. 
        /// </summary>
        /// <remarks>
        /// Note: This is just a rough classification for filtering offers. It 
        /// is up to the buying party to check the exact scope and terms and
        /// conditions of the gr:WarrantyPromise.
        /// </remarks>
        /// <example>http://purl.org/goodrelations/v1#PartsAndLabor-PickUp</example>
        [EnumMember(Value = "PartsAndLabor-PickUp")]
        PartsAndLaborPickUp = 30,
    }
}
