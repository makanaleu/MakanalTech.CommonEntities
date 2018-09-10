using CommonEntities.Core.Intangible;
using CommonEntities.Core.Intangible.Enumeration;
using CommonEntities.Core.Intangible.Quantity;
using CommonEntities.Core.Intangible.StructuredValue;
using CommonEntities.DataType;
using CommonEntities.MultiType;
using CommonEntities.MultiType.Alt;
using CommonEntities.MultiType.AltRef;
using CommonEntities.MultiType.Ref;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Boolean = CommonEntities.DataType.Boolean;
using DateTime = CommonEntities.DataType.DateTime;

namespace CommonEntities.Core
{
    /// <summary>
    /// The most generic kind of creative work, including books, movies, 
    /// photographs, software programs, etc.
    /// </summary>
    [DataContract(Name = "CreativeWork", Namespace = "https://www.schema.org/CreativeWork")]
    public class CreativeWork : Thing
    {
        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        /// <seealso cref="Thing.SubjectOf"/>
        /// <example>https://schema.org/about</example>
        [DataMember(Name = "about")]
        public Thing About { get; set; }

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        /// <example>https://schema.org/accessMode</example>
        [DataMember(Name = "accessMode")]
        public AccessMode AccessMode { get; set; }

        /// <summary>
        /// A list of AccessModes that are sufficient to understand all the 
        /// intellectual content of a resource.
        /// </summary>
        /// <example>https://schema.org/accessModeSufficient</example>
        [DataMember(Name = "accessModeSufficient")]
        public List<AccessMode> AccessModeSufficient { get; set; }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced 
        /// accessibility API.
        /// </summary>
        /// <example>https://schema.org/accessibilityAPI</example>
        [DataMember(Name = "accessibilityAPI")]
        public AccessibilityAPI AccessibilityAPI { get; set; }

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the 
        /// described resource.
        /// </summary>
        /// <example>https://schema.org/accessibilityControl</example>
        [DataMember(Name = "accessibilityControl")]
        public AccessibilityControl AccessibilityControl { get; set; }

        /// <summary>
        /// Content features of the resource, such as accessible media, 
        /// alternatives and supported enhancements for accessibility.
        /// </summary>
        /// <example>https://schema.org/accessibilityFeature</example>
        [DataMember(Name = "accessibilityFeature")]
        public AccessibilityFeature AccessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically 
        /// dangerous to some users.
        /// </summary>
        /// <remarks>
        /// If none of the hazards are known to exist instead of calling out 
        /// each nonHazard it is recommended to use "none". If the content has 
        /// hazard(s), include positive assertions for the hazards it has and 
        /// negative assertions for the others.
        /// </remarks>
        /// <example>https://schema.org/accessibilityHazard</example>
        [DataMember(Name = "accessibilityHazard")]
        public AccessibilityHazard AccessibilityHazard { get; set; }

        /// <summary>
        /// A human-readable summary of specific accessibility features or 
        /// deficiencies.
        /// </summary>
        /// <remarks>
        /// Consistent with the other accessibility metadata but expressing 
        /// subtleties such as "short descriptions are present but long 
        /// descriptions will be needed for non-visual users" or "short 
        /// descriptions are present and no long descriptions are needed."
        /// </remarks>
        /// <example>https://schema.org/accessibilitySummary</example>
        [DataMember(Name = "accessibilitySummary")]
        public Text AccessibilitySummary { get; set; }

        /// <summary>
        /// Specifies the Person that is legally accountable for the 
        /// CreativeWork.
        /// </summary>
        /// <example>https://schema.org/accountablePerson</example>
        [DataMember(Name = "accountablePerson")]
        public Person AccountablePerson { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of
        /// the item.
        /// </summary>
        /// <example>https://schema.org/aggregateRating</example>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        /// <example>https://schema.org/alternativeHeadline</example>
        [DataMember(Name = "alternativeHeadline")]
        public Text AlternativeHeadline { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a 
        /// synonym for encoding.
        /// </summary>
        /// <example>https://schema.org/associatedMedia</example>
        [DataMember(Name = "associatedMedia")]
        public MediaObject AssociatedMedia { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        /// <example>https://schema.org/audience</example>
        [DataMember(Name = "audience")]
        public Audience Audience { get; set; }


        /// <summary>
        /// An embedded audio object.
        /// </summary>
        /// <example>https://schema.org/audio</example>
        [DataMember(Name = "audio")]
        public AudioObject Audio { get; set; }

        /// <summary>
        /// The author of this content or rating.
        /// </summary>
        /// <remarks>
        /// Please note that author is special in that HTML 5 provides a 
        /// special mechanism for indicating authorship via the rel tag. That 
        /// is equivalent to this and may be used interchangeably.
        /// </remarks>
        /// <example>https://schema.org/author</example>
        [DataMember(Name = "author")]
        public OrganizationOrPerson Author { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        /// <seealso cref="Awards"/>
        /// <example>https://schema.org/award</example>
        [DataMember(Name = "award")]
        public Text Award { get; set; }

        /// <summary>
        /// Awards won by or for this item.
        /// </summary>
        /// <seealso cref="Award"/>
        /// <example>https://schema.org/awards</example>
        [DataMember(Name = "awards")]
        public List<Text> Awards { get; set; }

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        /// <example>https://schema.org/character</example>
        [DataMember(Name = "character")]
        public Person Character { get; set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another 
        /// publication, web page, scholarly article, etc.
        /// </summary>
        /// <example>https://schema.org/citation</example>
        [DataMember(Name = "citation")]
        public CreativeWorkOrText Citation { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        /// <example>https://schema.org/comment</example>
        [DataMember(Name = "comment")]
        public Comment Comment { get; set; }

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or
        /// Answer) has received.
        /// </summary>
        /// <remarks>
        /// This is most applicable to works published in Web sites with 
        /// commenting system; additional comments may exist elsewhere.
        /// </remarks>
        /// <example>https://schema.org/commentCount</example>
        [DataMember(Name = "commentCount")]
        public int CommentCount { get; set; }

        /// <summary>
        /// The location depicted or described in the content. For example, the
        /// location in a photograph or painting.
        /// </summary>
        /// <example>https://schema.org/contentLocation</example>
        [DataMember(Name = "contentLocation")]
        public Place ContentLocation { get; set; }

        /// <summary>
        /// Official rating of a piece of content—for example,'MPAA PG-13'.
        /// </summary>
        /// <example>https://schema.org/contentRating</example>
        [DataMember(Name = "contentRating")]
        public RatingOrText ContentRating { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        /// <example>https://schema.org/contributor</example>
        [DataMember(Name = "contributor")]
        public OrganizationOrPerson Contributor { get; set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        /// <example>https://schema.org/copyrightHolder</example>
        [DataMember(Name = "copyrightHolder")]
        public OrganizationOrPerson CopyrightHolder { get; set; }

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was
        /// first asserted.
        /// </summary>
        /// <example>https://schema.org/copyrightYear</example>
        [DataMember(Name = "copyrightYear")]
        public int CopyrightYear { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the 
        /// Author property for CreativeWork.
        /// </summary>
        /// <example>https://schema.org/creator</example>
        [DataMember(Name = "creator")]
        public OrganizationOrPerson Creator { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was 
        /// added to a DataFeed.
        /// </summary>
        /// <example>https://schema.org/dateCreated</example>
        [DataMember(Name = "dateCreated")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or
        /// when the item's entry was modified within a DataFeed.
        /// </summary>
        /// <example>https://schema.org/dateModified</example>
        [DataMember(Name = "dateModified")]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        /// <example>https://schema.org/datePublished</example>
        [DataMember(Name = "datePublished")]
        public DateTime DatePublished { get; set; }

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        /// <example>https://schema.org/discussionUrl</example>
        [DataMember(Name = "discussionUrl")]
        public URL DiscussionUrl { get; set; }

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        /// <example>https://schema.org/editor</example>
        [DataMember(Name = "editor")]
        public Person Editor { get; set; }

        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        /// <example>https://schema.org/educationalAlignment</example>
        [DataMember(Name = "educationalAlignment")]
        public AlignmentObject EducationalAlignment { get; set; }

        /// <summary>
        /// The purpose of a work in the context of education; for example, 
        /// 'assignment', 'group work'.
        /// </summary>
        /// <example>https://schema.org/educationalUse</example>
        [DataMember(Name = "educationalUse")]
        public Text EducationalUse { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork.
        /// </summary>
        /// <remarks>
        /// This property is a synonym for associatedMedia.
        /// </remarks>
        /// <example>https://schema.org/encoding</example>
        [DataMember(Name = "encoding")]
        public MediaObject Encoding { get; set; }

        /// <summary>
        /// Media type typically expressed using a MIME format (e.g. 
        /// application/zip, audio/mpeg).
        /// </summary>
        /// <remarks>
        /// See IANA (http://www.iana.org/assignments/media-types/media-types.xhtml) and 
        /// MDN (https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types).
        /// 
        /// Unregistered or niche encoding and file formats can be indicated
        /// instead via the most appropriate URL, e.g. defining Web page or a 
        /// Wikipedia/Wikidata entry.
        /// </remarks>
        /// <example>https://schema.org/encodingFormat</example>
        [DataMember(Name = "encodingFormat")]
        public Text EncodingFormat { get; set; }

        /// <summary>
        /// A creative work that this work is an 
        /// example/instance/realization/derivation of.
        /// </summary>
        /// <seealso cref="WorkExample"/>
        /// <example>https://schema.org/exampleOfWork</example>
        [DataMember(Name = "exampleOfWork")]
        public CreativeWork ExampleOfWork { get; set; }

        /// <summary>
        /// Date the content expires and is no longer useful or available. 
        /// </summary>
        /// <example>https://schema.org/expires</example>
        [DataMember(Name = "expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through
        /// some kind of financial contribution.
        /// </summary>
        /// <example>https://schema.org/funder</example>
        [DataMember(Name = "funder")]
        public OrganizationOrPerson Funder { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        /// <example>https://schema.org/genre</example>
        [DataMember(Name = "genre")]
        public Text Genre { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that is part of this item, or 
        /// CreativeWork (in some sense).
        /// </summary>
        /// <seealso cref="IsPartOf"/>
        /// <example>https://schema.org/hasPart</example>
        [DataMember(Name = "hasPart")]
        public CreativeWorkOrTrip HasPart { get; set; }

        /// <summary>
        /// Headline of the article.
        /// </summary>
        /// <example>https://schema.org/headline</example>
        [DataMember(Name = "headline")]
        public Text Headline { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. 
        /// </summary>
        /// <remarks>
        /// Please use one of the language codes from the IETF BCP 47 standard.
        /// See http://tools.ietf.org/html/bcp47.
        /// </remarks>
        /// <seealso cref="ContactPoint.AvailableLanguage"/>
        /// <seealso cref="ServiceChannel.AvailableLanguage"/>
        /// <example>https://schema.org/inLanguage</example>
        [DataMember(Name = "inLanguage")]
        public LanguageOrText InLanguage { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite 
        /// or SoftwareApplication. 
        /// </summary>
        /// <remarks>
        /// The most specific child type of InteractionCounter should be used.
        /// </remarks>
        /// <example>https://schema.org/interactionStatistic</example>
        [DataMember(Name = "interactionStatistic")]
        public InteractionCounter InteractionStatistic { get; set; }

        /// <summary>
        /// The predominant mode of learning supported by the learning resource.
        /// </summary>
        /// <example>https://schema.org/interactivityType</example>
        [DataMember(Name = "interactivityType")]
        public InteractivityType InteractivityType { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for 
        /// free.
        /// </summary>
        /// <example>https://schema.org/isAccessibleForFree</example>
        [DataMember(Name = "isAccessibleForFree")]
        public Boolean IsAccessibleForFree { get; set; }

        /// <summary>
        /// A resource that was used in the creation of this resource.
        /// </summary>
        /// <remarks>
        /// This term can be repeated for multiple sources.
        /// </remarks>
        /// <example>https://schema.org/isBasedOn</example>
        [DataMember(Name = "isBasedOn")]
        public List<CreativeWorkOrProductRef> IsBasedOn { get; set; }

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        /// <example>https://schema.org/isFamilyFriendly</example>
        [DataMember(Name = "isFamilyFriendly")]
        public Boolean IsFamilyFriendly { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that this item, or CreativeWork 
        /// (in some sense), is part of.
        /// </summary>
        /// <seealso cref="HasPart"/>
        /// <example>https://schema.org/isPartOf</example>
        [DataMember(Name = "isPartOf")]
        public CreativeWorkOrTrip IsPartOf { get; set; }

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in
        /// a keywords list are typically delimited by commas.
        /// </summary>
        /// <example>https://schema.org/keywords</example>
        [DataMember(Name = "keywords")]
        public Text Keywords { get; set; }

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. 
        /// For example, 'presentation', 'handout'.
        /// </summary>
        /// <example>https://schema.org/learningResourceType</example>
        [DataMember(Name = "learningResourceType")]
        public Text LearningResourceType { get; set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated
        /// by URL.
        /// </summary>
        /// <example>https://schema.org/license</example>
        [DataMember(Name = "license")]
        public CreativeWorkRef License { get; set; }

        /// <summary>
        /// The location where the CreativeWork was created, which may not be 
        /// the same as the location depicted in the CreativeWork.
        /// </summary>
        /// <example>https://schema.org/locationCreated</example>
        [DataMember(Name = "locationCreated")]
        public Place LocationCreated { get; set; }

        /// <summary>
        /// Indicates the primary entity described in some page or other 
        /// CreativeWork.
        /// </summary>
        /// <seealso cref="Thing.MainEntityOfPage"/>
        /// <example>https://schema.org/mainEntity</example>
        [DataMember(Name = "mainEntity")]
        public Thing MainEntity { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton,
        /// paper.
        /// </summary>
        /// <example>https://schema.org/material</example>
        [DataMember(Name = "locationCreated")]
        public ProductOrTextRef Material { get; set; }

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not
        /// necessarily about a concept.
        /// </summary>
        /// <example>https://schema.org/mentions</example>
        [DataMember(Name = "mentions")]
        public List<Thing> Mentions { get; set; }

        /// <summary>
        /// An offer to provide this item—for example, an offer to sell a 
        /// product, rent the DVD of a movie, perform a service, or give away 
        /// tickets to an event.
        /// </summary>
        /// <example>https://schema.org/offers</example>
        [DataMember(Name = "offers")]
        public List<Offer> Offers { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        /// <example>https://schema.org/position</example>
        [DataMember(Name = "position")]
        public TextOrInteger Position { get; set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album,
        /// movie, tv/radio series etc.).
        /// </summary>
        /// <example>https://schema.org/producer</example>
        [DataMember(Name = "producer")]
        public OrganizationOrPerson Producer { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the 
        /// goods producer.
        /// </summary>
        /// <remarks>
        /// Another party (a seller) may offer those services or goods on 
        /// behalf of the provider. A provider may also serve as the seller.
        /// </remarks>
        /// <example>https://schema.org/provider</example>
        [DataMember(Name = "provider")]
        public OrganizationOrPerson Provider { get; set; }

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        /// <example>https://schema.org/publication</example>
        [DataMember(Name = "publication")]
        public PublicationEvent Publication { get; set; }

        /// <summary>
        /// The publisher of the CreativeWork.
        /// </summary>
        /// <example>https://schema.org/publisher</example>
        [DataMember(Name = "publisher")]
        public OrganizationOrPerson Publisher { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via URL) a 
        /// document describing the editorial principles of an Organization (or
        /// individual e.g. a Person writing a blog) that relate to their 
        /// activities as a publisher, e.g. ethics or diversity policies.
        /// </summary>
        /// <remarks>
        /// When applied to a CreativeWork (e.g. NewsArticle) the principles 
        /// are those of the party primarily responsible for the creation of 
        /// the CreativeWork.
        /// </remarks>
        /// <example>https://schema.org/publishingPrinciples</example>
        [DataMember(Name = "publishingPrinciples")]
        public CreativeWorkRef PublishingPrinciples { get; set; }

        /// <summary>
        /// The Event where the CreativeWork was recorded.
        /// </summary>
        /// <remarks>
        /// The CreativeWork may capture all or part of the event.
        /// </remarks>
        /// <seealso cref="Event.RecordedIn"/>
        /// <example>https://schema.org/recordedAt</example>
        [DataMember(Name = "recordedAt")]
        public Event RecordedAt { get; set; }

        /// <summary>
        /// The place and time the release was issued, expressed as a 
        /// PublicationEvent.
        /// </summary>
        /// <example>https://schema.org/releasedEvent</example>
        [DataMember(Name = "releasedEvent")]
        public PublicationEvent ReleasedEvent { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        /// <seealso cref="Reviews"/>
        /// <example>https://schema.org/review</example>
        [DataMember(Name = "review")]
        public Review Review { get; set; }

        /// <summary>
        /// A list of reviews of the item.
        /// </summary>
        /// <seealso cref="Review"/>
        /// <example>https://schema.org/reviews</example>
        [DataMember(Name = "reviews")]
        public List<Review> Reviews { get; set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used
        /// in some CreativeWork.
        /// </summary>
        /// <remarks>
        /// For example, a document could declare a schemaVersion using an URL 
        /// such as http://schema.org/version/2.0/ if precise indication of 
        /// schema version was required by some application.
        /// </remarks>
        /// <example>https://schema.org/schemaVersion</example>
        [DataMember(Name = "schemaVersion")]
        public Text SchemaVersion { get; set; }

        /// <summary>
        /// The Organization on whose behalf the Creator was working.
        /// </summary>
        /// <example>https://schema.org/sourceOrganization</example>
        [DataMember(Name = "sourceOrganization")]
        public Organization SourceOrganization { get; set; }

        /// <summary>
        /// The SpatialCoverage of a CreativeWork indicates the place(s) which 
        /// are the focus of the content.
        /// </summary>
        /// <remarks>
        /// It is a subproperty of contentLocation intended primarily for more
        /// technical and detailed materials. For example with a Dataset, it 
        /// indicates areas that the dataset describes: a dataset of New York 
        /// weather would have SpatialCoverage which was the place: the state 
        /// of New York.
        /// </remarks>
        /// <example>https://schema.org/sourceOrganization</example>
        [DataMember(Name = "sourceOrganization")]
        public Place SpatialCoverage { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, 
        /// promise, or financial contribution. e.g. a sponsor of a Medical 
        /// Study or a corporate sponsor of an event.
        /// </summary>
        /// <example>https://schema.org/sponsor</example>
        [DataMember(Name = "sponsor")]
        public OrganizationOrPerson Sponsor { get; set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that 
        /// the content applies to.
        /// </summary>
        /// <example>https://schema.org/temporalCoverage</example>
        [DataMember(Name = "temporalCoverage")]
        public TemporalCoverage TemporalCoverage { get; set; }

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        /// <example>https://schema.org/text</example>
        [DataMember(Name = "text")]
        public Text Text { get; set; }

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        /// <example>https://schema.org/thumbnailUrl</example>
        [DataMember(Name = "thumbnailUrl")]
        public URL ThumbnailUrl { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this 
        /// learning resource for the typical intended target audience, e.g. 
        /// 'P30M', 'P1H25M'.
        /// </summary>
        /// <example>https://schema.org/timeRequired</example>
        [DataMember(Name = "timeRequired")]
        public Duration TimeRequired { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different 
        /// languages, regional differences and technical requirements of a 
        /// target market, or that translates during some event.
        /// </summary>
        /// <example>https://schema.org/translator</example>
        [DataMember(Name = "translator")]
        public OrganizationOrPerson Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        /// <example>https://schema.org/typicalAgeRange</example>
        [DataMember(Name = "typicalAgeRange")]
        public Text TypicalAgeRange { get; set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        /// <example>https://schema.org/version</example>
        [DataMember(Name = "version")]
        public Text Version { get; set; }

        /// <summary>
        /// An embedded video object.
        /// </summary>
        /// <example>https://schema.org/video</example>
        [DataMember(Name = "video")]
        public VideoObject Video { get; set; }

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this 
        /// creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        /// <seealso cref="ExampleOfWork"/>
        /// <example>https://schema.org/workExample</example>
        [DataMember(Name = "workExample")]
        public CreativeWork WorkExample { get; set; }
    }
}
