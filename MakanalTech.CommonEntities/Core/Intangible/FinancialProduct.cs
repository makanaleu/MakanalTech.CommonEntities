using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core.Intangible
{
    /// <summary>
    /// A product provided to consumers and businesses by financial institutions
    /// such as banks, insurance companies, brokerage firms, consumer finance 
    /// companies, and investment companies which comprise the financial services
    /// industry.
    /// </summary>
    [DataContract(Name = "FinancialProduct", Namespace = "https://schema.org/FinancialProduct")]
    public class FinancialProduct : Service
    {
        /// <summary>
        /// The annual rate that is charged for borrowing (or made by investing),
        /// expressed as a single percentage number that represents the actual
        /// yearly cost of funds over the term of a loan. This includes any 
        /// fees or additional costs associated with the transaction.
        /// </summary>
        /// <example>https://schema.org/annualPercentageRate</example>
        [DataMember(Name = "annualPercentageRate")]
        public QuantitativeValueOrNumber AnnualPercentageRate { get; set; }

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to
        /// a class of financial product, or by a financial service organization.
        /// </summary>
        /// <example>https://schema.org/feesAndCommissionsSpecification</example>
        [DataMember(Name = "feesAndCommissionsSpecification")]
        public TextRef FeesAndCommissionsSpecification { get; set; }

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial 
        /// product. Note: This is different from the calculated 
        /// annualPercentageRate.
        /// </summary>
        /// <example>https://schema.org/interestRate</example>
        [DataMember(Name = "interestRate")]
        public QuantitativeValueOrNumber InterestRate { get; set; }
    }
}
