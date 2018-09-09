using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible
{
    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed 
    /// terms and charges.
    /// </summary>
    [DataContract(Name = "LoanOrCredit", Namespace = "https://schema.org/LoanOrCredit")]
    public class LoanOrCredit : FinancialProduct
    {
        /// <summary>
        /// The amount of money.
        /// </summary>
        /// <example>https://schema.org/amount</example>
        [DataMember(Name = "amount")]
        public MonetaryAmountOrNumber Amount { get; set; }

        /// <summary>
        /// The duration of the loan or credit agreement.
        /// </summary>
        /// <example>https://schema.org/loanTerm</example>
        [DataMember(Name = "loanTerm")]
        public QuantitativeValue LoanTerm { get; set; }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take
        /// form of third party pledge, goods, financial instruments (cash,
        /// securities, etc.)
        /// </summary>
        /// <example>https://schema.org/requiredCollateral</example>
        [DataMember(Name = "requiredCollateral")]
        public ThingOrText RequiredCollateral { get; set; }
    }
}
