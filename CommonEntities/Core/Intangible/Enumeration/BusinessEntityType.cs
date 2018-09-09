using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// A business entity type is a conceptual entity representing the legal 
    /// form, the size, the main line of business, the position in the value 
    /// chain, or any combination thereof, of an organization or business 
    /// person.
    /// </summary>
    /// <remarks>
    /// This class is derived from the GoodRelations Vocabulary for E-Commerce,
    /// created by Martin Hepp. GoodRelations is a data model for sharing 
    /// e-commerce data on the Web that can be expressed in a variety of 
    /// syntaxes, including RDFa and HTML5 Microdata. More information about 
    /// GoodRelations can be found at http://purl.org/goodrelations/.
    /// </remarks>
    [DataContract(Name = "BusinessEntityType", Namespace = "https://schema.org/BusinessEntityType")]
    public enum BusinessEntityType
    {
        /// <summary>
        /// The gr:BusinessEntityType representing such agents that are 
        /// themselves offering commercial services or products on the market.
        /// Usually, businesses are characterized by the fact that they are 
        /// officially registered with the public administration and strive for
        /// profits by their activities.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Business</example>
        [EnumMember(Value = "Business")]
        Business = 10,

        /// <summary>
        /// The gr:BusinessEntityType representing such agents that are 
        /// purchasing the good or service for private consumption, in 
        /// particular not for resale or for usage within an industrial 
        /// enterprise. By default, a Business Entity is an Enduser.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Enduser</example>
        [EnumMember(Value = "Enduser")]
        Enduser = 20,

        /// <summary>
        /// The gr:BusinessEntityType representing such agents that are part of
        /// the adminstration or owned by the public.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#PublicInstitution</example>
        [EnumMember(Value = "PublicInstitution")]
        PublicInstitution = 30,

        /// <summary>
        /// The gr:BusinessEntityType representing such agents that are 
        /// purchasing the scope of products included in the gr:Offering for 
        /// resale on the market. Resellers are also businesses, i.e., they are
        /// officially registered with the public administration and strive for
        /// profits by their activities.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Reseller</example>
        [EnumMember(Value = "Reseller")]
        Reseller = 40
    }
}
