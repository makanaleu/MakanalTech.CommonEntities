using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Pending.Intangible.StructuredValue
{
    /// <summary>
    /// Pending Extension of Core.Intangible.StructuredValue.MonetaryAmount.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "MonetaryAmount", Namespace = "https://pending.schema.org/MonetaryAmount")]
    public class MonetaryAmount : Core.Intangible.StructuredValue.MonetaryAmount
    {
        /// <summary>
        /// The currency in which the monetary amount is expressed.
        /// </summary>
        /// <remarks>
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker 
        /// symbol for cryptocurrencies e.g. "BTC"; well known names for Local
        /// Exchange Tradings Systems (LETS) and other currency types e.g. 
        /// "Ithaca HOUR".
        /// </remarks>
        /// <example>https://pending.schema.org/currency</example>
        [DataMember(Name = "currency")]
        public Text Currency { get; set; }
    }
}
