using CommonEntities.Core.Intangible;
using CommonEntities.Core.Intangible.Enumeration;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// LoanOrCreditOrPaymentMethod MultiType accepts a LoanOrCredit or PaymentMethod.
    /// </summary>
    /// <example>https://schema.org/acceptedPaymentMethod</example>
    [DataContract(Name = "LoanOrCreditOrPaymentMethod", Namespace = "CommonEntities.MultiType.Alt")]
    public class LoanOrCreditOrPaymentMethod
    {
        /// <summary>
        /// LoanOrCreditOrPaymentMethod as a LoanOrCredit.
        /// </summary>
        [DataMember(Name = "asLoanOrCredit")]
        public LoanOrCredit AsLoanOrCredit;

        /// <summary>
        /// LoanOrCreditOrPaymentMethod as a PaymentMethod.
        /// </summary>
        [DataMember(Name = "asPaymentMethod")]
        public PaymentMethod? AsPaymentMethod;

        /// <summary>
        /// LoanOrCreditOrPaymentMethod as a LoanOrCredit.
        /// </summary>
        /// <param name="loanOrCredit">LoanOrCreditOrPaymentMethod as a LoanOrCredit.</param>
        public LoanOrCreditOrPaymentMethod(LoanOrCredit loanOrCredit)
        {
            AsLoanOrCredit = loanOrCredit;
        }

        /// <summary>
        /// LoanOrCreditOrPaymentMethod as a PaymentMethod.
        /// </summary>
        /// <param name="paymentMethod">LoanOrCreditOrPaymentMethod as a PaymentMethod.</param>
        public LoanOrCreditOrPaymentMethod(PaymentMethod paymentMethod)
        {
            AsPaymentMethod = paymentMethod;
        }

        /// <summary>
        /// LoanOrCreditOrPaymentMethod.
        /// </summary>
        public LoanOrCreditOrPaymentMethod() { }
    }
}
