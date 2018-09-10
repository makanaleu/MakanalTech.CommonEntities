using CommonEntities.Core;
using CommonEntities.Core.Intangible.StructuredValue;
using System.Runtime.Serialization;

namespace CommonEntities.MultiType.Alt
{
    /// <summary>
    /// ContactPointOrPlace MultiType accepts ContactPoint or Place.
    /// </summary>
    [DataContract(Name = "ContactPointOrPlace", Namespace = "CommonEntities.MultiType.Alt")]
    public class ContactPointOrPlace
    {
        /// <summary>
        /// ContactPointOrPlace as a ContactPoint.
        /// </summary>
        [DataMember(Name = "asContactPoint")]
        public ContactPoint AsContactPoint;

        /// <summary>
        /// ContactPointOrPlace as a Place.
        /// </summary>
        [DataMember(Name = "asPlace")]
        public Place AsPlace;

        /// <summary>
        /// ContactPointOrPlace as a ContactPoint.
        /// </summary>
        /// <param name="contactPoint">ContactPointOrPlace as a ContactPoint.</param>
        public ContactPointOrPlace(ContactPoint contactPoint)
        {
            AsContactPoint = contactPoint;
        }

        /// <summary>
        /// ContactPointOrPlace as a Place.
        /// </summary>
        /// <param name="place">ContactPointOrPlace as a Place.</param>
        public ContactPointOrPlace(Place place)
        {
            AsPlace = place;
        }

        /// <summary>
        /// ContactPointOrPlace.
        /// </summary>
        public ContactPointOrPlace() { }
    }
}
