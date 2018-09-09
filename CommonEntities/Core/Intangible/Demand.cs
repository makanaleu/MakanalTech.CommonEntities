using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible
{
    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not 
    /// necessarily exclusive, announcement by an organization or person to 
    /// seek a certain type of goods or services. For describing demand using 
    /// this type, the very same properties used for Offer apply.
    /// </summary>
    [DataContract(Name = "Demand", Namespace = "https://schema.org/Demand")]
    public class Demand : Offer
    {
    }
}
