using CommonEntities.Core.Intangible.Quantity;
using CommonEntities.DataType;
using CommonEntities.MultiType.Ref;
using CommonEntities.Pending.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace CommonEntities.Pending.Intangible
{
    /// <summary>
    /// Pending Extension of Core.Intangible.LoanOrCredit.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "LoanOrCredit", Namespace = "https://pending.schema.org/LoanOrCredit")]
    public class LoanOrCredit : Core.Intangible.LoanOrCredit
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

        /// <summary>
        /// The period of time after any due date that the borrower has to 
        /// fulfil its obligations before a default (failure to pay) is deemed 
        /// to have occurred.
        /// </summary>
        /// <example>https://pending.schema.org/gracePeriod</example>
        [DataMember(Name = "gracePeriod")]
        public Duration GracePeriod { get; set; }

        /// <summary>
        /// A form of paying back money previously borrowed from a lender. 
        /// Repayment usually takes the form of periodic payments that normally
        /// include part principal plus interest in each payment.
        /// </summary>
        /// <example>https://pending.schema.org/loanRepaymentForm</example>
        [DataMember(Name = "loanRepaymentForm")]
        public RepaymentSpecification LoanRepaymentForm { get; set; }

        /// <summary>
        /// The type of a loan or credit.
        /// </summary>
        /// <example>https://pending.schema.org/loanType</example>
        [DataMember(Name = "loanType")]
        public TextRef LoanType { get; set; }

        /// <summary>
        /// The only way you get the money back in the event of default is the 
        /// security. Recourse is where you still have the opportunity to go 
        /// back to the borrower for the rest of the money.
        /// </summary>
        /// <example>https://pending.schema.org/recourseLoan</example>
        [DataMember(Name = "recourseLoan")]
        public Boolean RecourseLoan { get; set; }

        /// <summary>
        /// Whether the terms for payment of interest can be renegotiated 
        /// during the life of the loan.
        /// </summary>
        /// <example>https://pending.schema.org/renegotiableLoan</example>
        [DataMember(Name = "renegotiableLoan")]
        public Boolean RenegotiableLoan { get; set; }
    }
}
