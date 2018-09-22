using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Combo;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MakanalTech.CommonEntities.DataType;
using DateTime = MakanalTech.CommonEntities.DataType.DateTime;
using Boolean = MakanalTech.CommonEntities.DataType.Boolean;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// An event happening at a certain time and location, such as a concert,
    /// lecture, or festival. Ticketing information may be added via the
    /// offers property. Repeated events may be structured as separate Event 
    /// objects.
    /// </summary>
    [DataContract(Name = "Organization", Namespace = "https://schema.org/Organization")]
    public class Event
    {
        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        /// <seealso cref="Thing.SubjectOf"/>
        /// <example>https://schema.org/about</example>
        [DataMember(Name = "about")]
        public Thing About { get; set; }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. 
        /// </summary>
        /// <remarks>
        /// Actors can be associated with individual items or with a series, 
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Actors"/>
        /// <example>https://schema.org/actor</example>
        [DataMember(Name = "actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// A list of actors, e.g. in tv, radio, movie, video games etc., or in
        /// an event. 
        /// </summary>
        /// <remarks>
        /// Actors can be associated with individual items or with a series, 
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Actor"/>
        /// <example>https://schema.org/actors</example>
        [DataMember(Name = "actors")]
        public List<Person> Actors { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of
        /// the item.
        /// </summary>
        /// <example>https://schema.org/aggregateRatings</example>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        /// <seealso cref="Attendees"/>
        /// <example>https://schema.org/attendee</example>
        [DataMember(Name = "attendee")]
        public OrganizationOrPerson Attendee { get; set; }

        /// <summary>
        /// A list of people and/or organizations attending the event.
        /// </summary>
        /// <seealso cref="Attendee"/>
        /// <example>https://schema.org/attendees</example>
        [DataMember(Name = "attendees")]
        public List<OrganizationOrPerson> Attendees { get; set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the 
        /// composer of a work performed at some event.
        /// </summary>
        /// <example>https://schema.org/composer</example>
        [DataMember(Name = "composer")]
        public OrganizationOrPerson Composer { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        /// <example>https://schema.org/contributor</example>
        [DataMember(Name = "contributor")]
        public OrganizationOrPerson Contributor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or 
        /// of an event.
        /// </summary>
        /// <remarks>
        /// Directors can be associated with individual items or with a series,
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Directors"/>
        /// <example>https://schema.org/director</example>
        [DataMember(Name = "director")]
        public Person Director { get; set; }

        /// <summary>
        /// A list of directors of e.g. tv, radio, movie, video gaming etc. 
        /// content, or of an event.
        /// </summary>
        /// <remarks>
        /// Directors can be associated with individual items or with a series, 
        /// episode, clip.
        /// </remarks>
        /// <seealso cref="Director"/>
        /// <example>https://schema.org/directors</example>
        [DataMember(Name = "directors")]
        public List<Person> Directors { get; set; }

        /// <summary>
        /// The time admission will commence.
        /// </summary>
        /// <example>https://schema.org/doorTime</example>
        [DataMember(Name = "doorTime")]
        public DateTime DoorTime { get; set; }

        /// <summary>
        /// The end date and time of the item (in ISO 8601 date format).
        /// </summary>
        /// <remarks>
        /// See http://en.wikipedia.org/wiki/ISO_8601.
        /// </remarks>
        /// <example>https://schema.org/endDate</example>
        [DataMember(Name = "endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// An eventStatus of an event represents its status; particularly 
        /// useful when an event is cancelled or rescheduled.
        /// </summary>
        /// <example>https://schema.org/eventStatus</example>
        [DataMember(Name = "eventStatus")]
        public EventStatusType EventStatus { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through
        /// some kind of financial contribution.
        /// </summary>
        /// <example>https://schema.org/funder</example>
        [DataMember(Name = "funder")]
        public OrganizationOrPerson Funder { get; set; }

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
        /// A flag to signal that the item, event, or place is accessible for 
        /// free.
        /// </summary>
        /// <example>https://schema.org/isAccessibleForFree</example>
        [DataMember(Name = "isAccessibleForFree")]
        public Boolean IsAccessibleForFree { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an 
        /// organization is located, or where an action takes place.
        /// </summary>
        /// <example>https://schema.org/location</example>
        [DataMember(Name = "location")]
        public PlacePostalAddressOrText Location { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        /// <example>https://schema.org/maximumAttendeeCapacity</example>
        [DataMember(Name = "maximumAttendeeCapacity")]
        public int MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// An offer to provide this item—for example, an offer to sell a 
        /// product, rent the DVD of a movie, perform a service, or give away 
        /// tickets to an event.
        /// </summary>
        /// <example>https://schema.org/offers</example>
        [DataMember(Name = "offers")]
        public List<Offer> Offers { get; set; }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        /// <example>https://schema.org/organizer</example>
        [DataMember(Name = "organizer")]
        public OrganizationOrPerson Organizer { get; set; }

        /// <summary>
        /// A performer at the event—for example, a presenter, musician, 
        /// musical group or actor.
        /// </summary>
        /// <seealso cref="Performers"/>
        /// <example>https://schema.org/performer</example>
        [DataMember(Name = "performer")]
        public OrganizationOrPerson Performer { get; set; }

        /// <summary>
        /// A list of performers at the event—for example, a presenter, 
        /// musician, musical group or actor.
        /// </summary>
        /// <seealso cref="Performer"/>
        /// <example>https://schema.org/performers</example>
        [DataMember(Name = "performers")]
        public List<OrganizationOrPerson> Performers { get; set; }

        /// <summary>
        /// Used in conjunction with eventStatus for rescheduled or cancelled
        /// events.
        /// </summary>
        /// <remarks>
        /// This property contains the previously scheduled start date. For 
        /// rescheduled events, the startDate property should be used for the 
        /// newly scheduled start date. In the (rare) case of an event that has
        /// been postponed and rescheduled multiple times, this field may be 
        /// repeated.
        /// </remarks>
        /// <seealso cref="EventStatus"/>
        /// <example>https://schema.org/previousStartDate</example>
        [DataMember(Name = "previousStartDate")]
        public List<DateTime> PreviousStartDate { get; set; }

        /// <summary>
        /// The CreativeWork that captured all or part of this Event.
        /// </summary>
        /// <seealso cref="CreativeWork.RecordedAt"/>
        /// <example>https://schema.org/recordedIn</example>
        [DataMember(Name = "recordedIn")]
        public CreativeWork RecordedIn { get; set; }

        /// <summary>
        /// The number of attendee places for an event that remain unallocated.
        /// </summary>
        /// <example>https://schema.org/remainingAttendeeCapacity</example>
        [DataMember(Name = "remainingAttendeeCapacity")]
        public int RemainingAttendeeCapacity { get; set; }

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
        /// A person or organization that supports a thing through a pledge, 
        /// promise, or financial contribution. e.g. a sponsor of a Medical 
        /// Study or a corporate sponsor of an event.
        /// </summary>
        /// <example>https://schema.org/sponsor</example>
        [DataMember(Name = "sponsor")]
        public OrganizationOrPerson Sponsor { get; set; }

        /// <summary>
        /// The start date and time of the item (in ISO 8601 date format).
        /// </summary>
        /// <remarks>
        /// See http://en.wikipedia.org/wiki/ISO_8601.
        /// </remarks>
        /// <example>https://schema.org/startDate</example>
        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// An Event that is part of this event.
        /// </summary>
        /// <remarks>
        /// For example, a conference event includes many presentations, each 
        /// of which is a subEvent of the conference.
        /// </remarks>
        /// <seealso cref="SubEvents"/>
        /// <seealso cref="SuperEvent"/>
        /// <example>https://schema.org/subEvent</example>
        [DataMember(Name = "subEvent")]
        public Event SubEvent { get; set; }

        /// <summary>
        /// A list of Events that is part of this event.
        /// </summary>
        /// <remarks>
        /// For example, a conference event includes many presentations, each 
        /// of which is a subEvent of the conference.
        /// </remarks>
        /// <seealso cref="SubEvent"/>
        /// <seealso cref="SuperEvent"/>
        /// <example>https://schema.org/subEvents</example>
        [DataMember(Name = "subEvents")]
        public List<Event> SubEvents { get; set; }

        /// <summary>
        /// An event that this event is a part of.
        /// </summary>
        /// <remarks>
        /// For example, a collection of individual music performances might 
        /// each have a music festival as their superEvent.
        /// </remarks>
        /// <seealso cref="SubEvent"/>
        /// <example>https://schema.org/superEvent</example>
        [DataMember(Name = "superEvent")]
        public Event SuperEvent { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different 
        /// languages, regional differences and technical requirements 
        /// of a target market, or that translates during some event.
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
        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent. 
        /// </summary>
        /// <remarks>
        /// Specific subproperties are available for workPerformed (e.g. a play),
        /// or a workPresented (a Movie at a ScreeningEvent).
        /// </remarks>
        /// <example>https://schema.org/workFeatured</example>
        [DataMember(Name = "workFeatured")]
        public CreativeWork WorkFeatured { get; set; }

        /// <summary>
        /// A work performed in some event, for example a play performed in a 
        /// TheaterEvent. 
        /// </summary>
        /// <example>https://schema.org/workPerformed</example>
        [DataMember(Name = "workPerformed")]
        public CreativeWork WorkPerformed { get; set; }
    }
}
