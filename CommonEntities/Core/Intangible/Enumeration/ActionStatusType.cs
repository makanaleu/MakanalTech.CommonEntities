using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible.Enumeration
{
    /// <summary>
    /// The status of an Action.
    /// </summary>
    [DataContract(Name = "ActionStatusType", Namespace = "https://schema.org/ActiveActionStatus")]
    public enum ActionStatusType
    {
        /// <summary>
        /// An in-progress action (e.g, while watching the movie, or 
        /// driving to a location).
        /// </summary>
        /// <example>https://schema.org/ActiveActionStatus</example>
        [EnumMember(Value = "ActiveActionStatus")]
        ActiveActionStatus = 10,

        /// <summary>
        /// An action that has already taken place.
        /// </summary>
        /// <example>https://schema.org/CompletedActionStatus</example>
        [EnumMember(Value = "CompletedActionStatus")]
        CompletedActionStatus = 20,

        /// <summary>
        /// An action that failed to complete. The action's error property and
        /// the HTTP return code contain more information about the failure.
        /// </summary>
        /// <example>https://schema.org/FailedActionStatus</example>
        [EnumMember(Value = "FailedActionStatus")]
        FailedActionStatus = 30,

        /// <summary>
        /// A description of an action that is supported.
        /// </summary>
        /// <example>https://schema.org/PotentialActionStatus</example>
        [EnumMember(Value = "PotentialActionStatus")]
        PotentialActionStatus = 40
    }
}
