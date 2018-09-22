using MakanalTech.CommonEntities.Core.Intangible;
using MakanalTech.CommonEntities.Core.Intangible.Enumeration;
using MakanalTech.CommonEntities.MultiType.Alt;
using MakanalTech.CommonEntities.MultiType.Combo;
using System;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Core
{
    /// <summary>
    /// An action performed by a direct agent and indirect participants upon 
    /// a direct object.
    /// </summary>
    /// <remarks>
    /// Optionally happens at a location with the help of an inanimate instrument. 
    /// The execution of the action may produce a result. Specific action sub-type 
    /// documentation specifies the exact expectation of each argument/role.
    /// </remarks>
    [DataContract(Name = "Action", Namespace = "https://schema.org/Action")]
    public class Action : Thing
    {
        /// <summary>
        /// Indicates the current disposition of the Action.
        /// </summary>
        /// <example>https://schema.org/actionStatus</example>
        [DataMember(Name = "actionStatus")]
        public ActionStatusType ActionStatus { get; set; }

        /// <summary>
        /// The direct performer or driver of the action (animate or inanimate). 
        /// e.g. John wrote a book.
        /// </summary>
        /// <example>https://schema.org/agent</example>
        [DataMember(Name = "agent")]
        public OrganizationOrPerson Agent { get; set; }

        /// <summary>
        /// The endTime of something.
        /// </summary>
        /// <remarks>
        /// For a reserved event or service (e.g. FoodEstablishmentReservation), 
        /// the time that it is expected to end. For actions that span a period of 
        /// time, when the action was performed. e.g. John wrote a book from January
        /// to December.
        /// 
        /// Note that Event uses startDate/endDate instead of startTime/endTime, 
        /// even when describing dates with times.This situation may be clarified 
        /// in future revisions.
        /// </remarks>
        /// <example>https://schema.org/endTime</example>
        [DataMember(Name = "endTime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// For failed actions, more information on the cause of the failure.
        /// </summary>
        /// <example>https://schema.org/error</example>
        [DataMember(Name = "error")]
        public Thing Error { get; set; }

        /// <summary>
        /// The object that helped the agent perform the action. e.g. John wrote 
        /// a book with a pen.
        /// </summary>
        /// <example>https://schema.org/instrument</example>
        [DataMember(Name = "instrument")]
        public Thing Instrument { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an 
        /// organization is located, or where an action takes place.
        /// </summary>
        /// <example>https://schema.org/location</example>
        [DataMember(Name = "location")]
        public PlacePostalAddressOrText Location { get; set; }

        /// <summary>
        /// The object upon which the action is carried out, whose state is 
        /// kept intact or changed.
        /// </summary>
        /// <remarks>
        /// Also known as the semantic roles patient, affected or undergoer 
        /// (which change their state) or theme (which doesn't). e.g. 
        /// John read a book.
        /// </remarks>
        /// <example>https://schema.org/object</example>
        [DataMember(Name = "object")]
        public Thing Object { get; set; }

        /// <summary>
        /// Other co-agents that participated in the action indirectly. 
        /// e.g. John wrote a book with Steve.
        /// </summary>
        /// <example>https://schema.org/participant</example>
        [DataMember(Name = "participant")]
        public OrganizationOrPerson Participant { get; set; }

        /// <summary>
        /// The result produced in the action. e.g. John wrote a book.
        /// </summary>
        /// <example>https://schema.org/result</example>
        [DataMember(Name = "result")]
        public Thing Result { get; set; }

        /// <summary>
        /// The startTime of something.
        /// </summary>
        /// <remarks>
        /// For a reserved event or service (e.g. FoodEstablishmentReservation), 
        /// the time that it is expected to start. For actions that span a 
        /// period of time, when the action was performed. e.g. John wrote a 
        /// book from January to December.
        ///  
        /// Note that Event uses startDate/endDate instead of startTime/endTime,
        /// even when describing dates with times. This situation may be clarified
        /// in future revisions.
        /// </remarks>
        /// <example>https://schema.org/startTime</example>
        [DataMember(Name = "startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Indicates a target EntryPoint for an Action.
        /// </summary>
        /// <example>https://schema.org/target</example>
        [DataMember(Name = "target")]
        public EntryPoint Target { get; set; }
    }
}
