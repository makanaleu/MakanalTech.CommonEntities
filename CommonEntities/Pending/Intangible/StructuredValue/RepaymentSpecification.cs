using CommonEntities.DataType;
using CommonEntities.MultiType.Alt;
using System.Runtime.Serialization;

namespace CommonEntities.Pending.Intangible.StructuredValue
{
    /// <summary>
    /// Pending Extension of Core.Intangible.StructuredValue.RepaymentSpecification.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "MonetaryAmount", Namespace = "https://pending.schema.org/MonetaryAmount")]
    public class RepaymentSpecification : Thing
    {
        /// <summary>
        /// A type of payment made in cash during the onset of the purchase of
        /// an expensive good/service. The payment typically represents only a 
        /// percentage of the full purchase price.
        /// </summary>
        /// <example>https://pending.schema.org/downPayment</example>
        [DataMember(Name = "downPayment")]
        public MonetaryAmountOrNumber DownPayment { get; set; }

        /// <summary>
        /// The amount to be paid as a penalty in the event of early payment of
        /// the loan.
        /// </summary>
        /// <example>https://pending.schema.org/earlyPrepaymentPenalty</example>
        [DataMember(Name = "earlyPrepaymentPenalty")]
        public MonetaryAmount EarlyPrepaymentPenalty { get; set; }

        /// <summary>
        /// The amount of money to pay in a single payment.
        /// </summary>
        /// <example>https://pending.schema.org/loanPaymentAmount</example>
        [DataMember(Name = "loanPaymentAmount")]
        public MonetaryAmount LoanPaymentAmount { get; set; }

        /// <summary>
        /// Frequency of payments due, i.e. number of months between payments. 
        /// This is defined as a frequency, i.e. the reciprocal of a period of
        /// time.
        /// </summary>
        /// <example>https://pending.schema.org/loanPaymentFrequency</example>
        [DataMember(Name = "loanPaymentFrequency")]
        public Number LoanPaymentFrequency { get; set; }

        /// <summary>
        /// The number of payments contractually required at origination to 
        /// repay the loan. For monthly paying loans this is the number of 
        /// months from the contractual first payment date to the maturity date.
        /// </summary>
        /// <example>https://pending.schema.org/numberOfLoanPayments</example>
        [DataMember(Name = "numberOfLoanPayments")]
        public Number NumberOfLoanPayments { get; set; }
    }
}
