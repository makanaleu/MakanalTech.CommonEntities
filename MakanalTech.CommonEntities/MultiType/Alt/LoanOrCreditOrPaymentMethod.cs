using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// LoanOrCreditOrPaymentMethod MultiType accepts a LoanOrCredit or PaymentMethod.
    /// </summary>
    /// <example>https://schema.org/acceptedPaymentMethod</example>
    [DataContract(Name = "LoanOrCreditOrPaymentMethod", Namespace = "CommonEntities.MultiType.Alt")]
    public class LoanOrCreditOrPaymentMethod
    {
        /// <summary>
        /// ApplicationKey allows base classes to be used in a relational
        /// data management environment where a key is required.
        /// </summary>
        [DataMember(Name = "applicationKey")]
        public Guid? ApplicationKey { get; set; }

        /// <summary>
        /// LoanOrCreditOrPaymentMethod as a LoanOrCredit.
        /// </summary>
        [DataMember(Name = "asLoanOrCredit")]
        public LoanOrCredit AsLoanOrCredit { get; set; }

        /// <summary>
        /// LoanOrCreditOrPaymentMethod as a PaymentMethod.
        /// </summary>
        [DataMember(Name = "asPaymentMethod")]
        public PaymentMethod AsPaymentMethod { get; set; }

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
