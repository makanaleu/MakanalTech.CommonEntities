using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Pending
{
    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to 
    /// accommodate definitions from Geo-Spatial best practices.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "GeospatialGeometry", Namespace = "https://pending.schema.org/GeospatialGeometry")]
    public class GeospatialGeometry : Place
    {
    }
}
