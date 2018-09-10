using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// A delivery method is a standardized procedure for transferring the 
    /// product or service to the destination of fulfillment chosen by the 
    /// customer. Delivery methods are characterized by the means of 
    /// transportation used, and by the organization or group that is the 
    /// contracting party for the sending organization or person.
    /// </summary>
    /// <remarks>
    /// This class is derived from the GoodRelations Vocabulary for E-Commerce,
    /// created by Martin Hepp. GoodRelations is a data model for sharing 
    /// e-commerce data on the Web that can be expressed in a variety of 
    /// syntaxes, including RDFa and HTML5 Microdata. More information about 
    /// GoodRelations can be found at http://purl.org/goodrelations/.
    /// </remarks>
    [DataContract(Name = "DeliveryMethod", Namespace = "https://schema.org/DeliveryMethod")]
    public enum DeliveryMethod
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Delivery of the goods via direct download from the Internet, i.e., 
        /// the offering gr:BusinessEntity provides the buying party with 
        /// details on how to retrieve the goods online. Connection fees and 
        /// other costs of using the infrastructure are to be carried by the 
        /// buying party.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#DeliveryModeDirectDownload</example>
        [EnumMember(Value = "DeliveryModeDirectDownload")]
        DeliveryModeDirectDownload = 10,

        /// <summary>
        /// Delivery by an unspecified air, sea, or ground freight carrier or 
        /// cargo company.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#DeliveryModeFreight</example>
        [EnumMember(Value = "DeliveryModeFreight")]
        DeliveryModeFreight = 20,

        /// <summary>
        /// Delivery via regular mail service (private or public postal services).
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#DeliveryModeMail</example>
        [EnumMember(Value = "DeliveryModeMail")]
        DeliveryModeMail = 30,

        /// <summary>
        /// Delivery of the goods by using a fleet of vehicles either owned and
        /// operated or subcontracted by the gr:BusinessEntity.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#DeliveryModeOwnFleet</example>
        [EnumMember(Value = "DeliveryModeOwnFleet")]
        DeliveryModeOwnFleet = 40,

        /// <summary>
        /// Delivery of the goods by picking them up at one of the stores etc.
        /// (gr:Location) during the opening hours as specified by respective 
        /// instances of gr:OpeningHoursSpecification.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#DeliveryModePickUp</example>
        [EnumMember(Value = "DeliveryModePickUp")]
        DeliveryModePickUp = 50,

        /// <summary>
        /// Delivery via the parcel service DHL.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#DHL</example>
        [EnumMember(Value = "DHL")]
        DHL = 60,

        /// <summary>
        /// Delivery via the parcel service Federal Express.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#FederalExpress</example>
        [EnumMember(Value = "FederalExpress")]
        FederalExpress = 70,

        /// <summary>
        /// Delivery via the parcel service UPS.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#UPS</example>
        [EnumMember(Value = "UPS")]
        UPS = 80
    }
}
