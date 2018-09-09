using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A dataset in downloadable form.
    /// </summary>
    [DataContract(Name = "DataDownload", Namespace = "https://schema.org/DataDownload")]
    public class DataDownload : MediaObject
    {
    }
}
