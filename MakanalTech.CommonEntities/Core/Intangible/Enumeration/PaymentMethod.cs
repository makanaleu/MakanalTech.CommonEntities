using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// A payment method is a standardized procedure for transferring the 
    /// monetary amount for a purchase. Payment methods are characterized by 
    /// the legal and technical structures used, and by the organization or
    /// group carrying out the transaction.
    /// </summary>
    /// <remarks>
    /// This class is derived from the GoodRelations Vocabulary for E-Commerce,
    /// created by Martin Hepp. GoodRelations is a data model for sharing 
    /// e-commerce data on the Web that can be expressed in a variety of 
    /// syntaxes, including RDFa and HTML5 Microdata. More information about 
    /// GoodRelations can be found at http://purl.org/goodrelations/.
    /// </remarks>
    [DataContract(Name = "PaymentMethod", Namespace = "https://schema.org/PaymentMethod")]
    public enum PaymentMethod
    {
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Payment by bank transfer in advance, i.e., the offering 
        /// gr:BusinessEntity will inform the buying party about their bank 
        /// account details and will deliver the goods upon receipt of the due
        /// amount. This is equivalent to payment by wire transfer.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#ByBankTransferInAdvance</example>
        [EnumMember(Value = "ByBankTransferInAdvance")]
        ByBankTransferInAdvance = 10,

        /// <summary>
        /// Payment by bank transfer after delivery, i.e., the offering 
        /// gr:BusinessEntity will deliver first, inform the buying party about
        /// the due amount and their bank account details, and expect payment 
        /// shortly after delivery.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#ByInvoice</example>
        [EnumMember(Value = "ByInvoice")]
        ByInvoice = 20,

        /// <summary>
        /// Payment by cash upon delivery or pickup.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#Cash</example>
        [EnumMember(Value = "Cash")]
        Cash = 30,

        /// <summary>
        /// Payment by sending a check in advance, i.e., the offering 
        /// gr:BusinessEntity will deliver the goods upon receipt of a check 
        /// over the due amount. There are variations in handling payment by 
        /// check - sometimes, shipment will be upon receipt of the check as a 
        /// document, sometimes the shipment will take place only upon 
        /// successful crediting of the check.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#CheckInAdvance</example>
        [EnumMember(Value = "CheckInAdvance")]
        CheckInAdvance = 40,

        /// <summary>
        /// Collect on delivery / Cash on delivery - A payment method where the
        /// recipient of goods pays at the time of delivery. Usually, the amount
        /// of money is collected by the transportation company handling the goods.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#COD</example>
        [EnumMember(Value = "COD")]
        COD = 50,

        /// <summary>
        /// Payment by direct debit, i.e., the buying party will inform the 
        /// offering gr:BusinessEntity about its bank account details and 
        /// authorizes the gr:BusinessEntity to collect the agreed amount 
        /// directly from that account.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#DirectDebit</example>
        [EnumMember(Value = "DirectDebit")]
        DirectDebit = 60,

        /// <summary>
        /// Payment via the Google Checkout payment service.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#GoogleCheckout</example>
        [EnumMember(Value = "GoogleCheckout")]
        GoogleCheckout = 70,

        /// <summary>
        /// Payment via the PayPal payment service.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#PayPal</example>
        [EnumMember(Value = "PayPal")]
        PayPal = 80,

        /// <summary>
        /// Payment via the PaySwarm distributed micropayment service.
        /// </summary>
        /// <example>http://purl.org/goodrelations/v1#PaySwarm</example>
        [EnumMember(Value = "PaySwarm")]
        PaySwarm = 90
    }
}
