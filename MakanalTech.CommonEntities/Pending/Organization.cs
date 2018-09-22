using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.AltRef;
using MakanalTech.CommonEntities.MultiType.Combo;
using MakanalTech.CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// Pending Extension of Core.Organization.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Organization", Namespace = "https://pending.schema.org/Organization")]
    public class Organization
    {
        /// <summary>
        /// For a NewsMediaOrganization or other news-related Organization, a 
        /// statement about public engagement activities (for news media, the 
        /// newsroom’s), including involving the public - digitally or otherwise
        /// -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        /// <example>https://pending.schema.org/actionableFeedbackPolicy</example>
        [DataMember(Name = "actionableFeedbackPolicy")]
        public CreativeWork ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// For an Organization (e.g. NewsMediaOrganization), a statement 
        /// describing (in news media, the newsroom’s) disclosure and correction
        /// policy for errors.
        /// </summary>
        /// <example>https://pending.schema.org/correctionsPolicy</example>
        [DataMember(Name = "correctionsPolicy")]
        public CreativeWorkRef CorrectionsPolicy { get; set; }

        /// <summary>
        /// Statement on diversity policy by an Organization e.g. a 
        /// NewsMediaOrganization. For a NewsMediaOrganization, a statement
        /// describing the newsroom’s diversity policy on both staffing and 
        /// sources, typically providing staffing data.
        /// </summary>
        /// <example>https://pending.schema.org/diversityPolicy</example>
        [DataMember(Name = "diversityPolicy")]
        public CreativeWorkRef DiversityPolicy { get; set; }

        /// <summary>
        /// For an Organization (often but not necessarily a 
        /// NewsMediaOrganization), a report on staffing diversity issues. In a 
        /// news context this might be for example ASNE or RTDNA (US) reports, 
        /// or self-reported.
        /// </summary>
        /// <example>https://pending.schema.org/diversityStaffingReport</example>
        [DataMember(Name = "diversityStaffingReport")]
        public ArticleRef DiversityStaffingReport { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a NewsMediaOrganization 
        /// regarding journalistic and publishing practices, or of a Restaurant,
        /// a page describing food source policies. In the case of a 
        /// NewsMediaOrganization, an ethicsPolicy is typically a statement 
        /// describing the personal, organizational, and corporate standards of
        /// behavior expected by the organization.
        /// </summary>
        /// <example>https://pending.schema.org/ethicsPolicy</example>
        [DataMember(Name = "ethicsPolicy")]
        public CreativeWorkRef EthicsPolicy { get; set; }

        /// <summary>
        /// Of a Person, and less typically of an Organization, to indicate a 
        /// topic that is known about - suggesting possible expertise but not 
        /// implying it.
        /// </summary>
        /// <remarks>
        /// We do not distinguish skill levels here, or yet relate this to 
        /// educational content, events, objectives or JobPosting descriptions.
        /// </remarks>
        /// <example>https://pending.schema.org/knowsAbout</example>
        [DataMember(Name = "knowsAbout")]
        public ThingOrTextRef KnowsAbout { get; set; }

        /// <summary>
        /// Of a Person, and less typically of an Organization, to indicate a 
        /// known language.
        /// </summary>
        /// <remarks>
        /// We do not distinguish skill levels or reading/writing/speaking/signing
        /// here. Use language codes from the IETF BCP 47 standard. 
        /// See http://tools.ietf.org/html/bcp47.
        /// </remarks>
        /// <example>https://pending.schema.org/knowsLanguage</example>
        [DataMember(Name = "knowsLanguage")]
        public LanguageOrText KnowsLanguage { get; set; }

        /// <summary>
        /// For an Organization (often but not necessarily a 
        /// NewsMediaOrganization), a description of organizational ownership
        /// structure; funding and grants.
        /// </summary>
        /// <remarks>
        /// In a news/media setting, this is with particular reference to 
        /// editorial independence. Note that the funder is also available and 
        /// can be used to make basic funder informa
        /// </remarks>
        /// <example>https://pending.schema.org/ownershipFundingInfo</example>
        [DataMember(Name = "ownershipFundingInfo")]
        public CreativeWorkAboutPageOrTextRef OwnershipFundingInfo { get; set; }

        /// <summary>
        /// For an Organization (typically a NewsMediaOrganization), a statement
        /// about policy on use of unnamed sources and the decision process 
        /// required.
        /// </summary>
        /// <example>https://pending.schema.org/unnamedSourcesPolicy</example>
        [DataMember(Name = "unnamedSourcesPolicy")]
        public CreativeWorkRef UnnamedSourcesPolicy { get; set; }
    }
}
