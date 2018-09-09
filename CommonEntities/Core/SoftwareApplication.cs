using CommonEntities.DataType;
using CommonEntities.MultiType.Ref;
using System.Runtime.Serialization;

namespace CommonEntities.Core
{
    /// <summary>
    /// A software application.
    /// </summary>
    [DataContract(Name = "SoftwareApplication", Namespace = "https://schema.org/SoftwareApplication")]
    public class SoftwareApplication
    {
        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        /// <example>https://schema.org/applicationCategory</example>
        [DataMember(Name = "applicationCategory")]
        public TextRef ApplicationCategory { get; set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        /// <example>https://schema.org/applicationSubCategory</example>
        [DataMember(Name = "applicationSubCategory")]
        public TextRef ApplicationSubCategory { get; set; }

        /// <summary>
        /// The name of the application suite to which the application belongs
        /// (e.g. Excel belongs to Office).
        /// </summary>
        /// <example>https://schema.org/applicationSuite</example>
        [DataMember(Name = "applicationSuite")]
        public Text applicationSuite { get; set; }

        /// <summary>
        /// Device required to run the application. Used in cases where a 
        /// specific make/model is required to run the application.
        /// </summary>
        /// <example>https://schema.org/availableOnDevice</example>
        [DataMember(Name = "availableOnDevice")]
        public Text AvailableOnDevice { get; set; }

        /// <summary>
        /// Countries for which the application is not supported. You can also 
        /// provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        /// <example>https://schema.org/countriesNotSupported</example>
        [DataMember(Name = "countriesNotSupported")]
        public Text CountriesNotSupported { get; set; }

        /// <summary>
        /// Countries for which the application is supported. You can also 
        /// provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        /// <example>https://schema.org/countriesSupported</example>
        [DataMember(Name = "countriesSupported")]
        public Text CountriesSupported { get; set; }

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        /// <example>https://schema.org/downloadUrl</example>
        [DataMember(Name = "downloadUrl")]
        public URL DownloadUrl { get; set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly 
        /// required by other applications).
        /// </summary>
        /// <example>https://schema.org/featureList</example>
        [DataMember(Name = "featureList")]
        public TextRef FeatureList { get; set; }

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a 
        /// unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        /// <example>https://schema.org/fileSize</example>
        [DataMember(Name = "fileSize")]
        public Text FileSize { get; set; }

        /// <summary>
        /// URL at which the app may be installed, if different from the URL 
        /// of the item.
        /// </summary>
        /// <example>https://schema.org/installUrl</example>
        [DataMember(Name = "installUrl")]
        public URL InstallUrl { get; set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        /// <example>https://schema.org/memoryRequirements</example>
        [DataMember(Name = "memoryRequirements")]
        public TextRef MemoryRequirements { get; set; }

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        /// <example>https://schema.org/operatingSystem</example>
        [DataMember(Name = "operatingSystem")]
        public Text OperatingSystem { get; set; }

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app 
        /// may require full internet access or may run only on wifi).
        /// </summary>
        /// <example>https://schema.org/permissions</example>
        [DataMember(Name = "permissions")]
        public Text Permissions { get; set; }

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        /// <example>https://schema.org/processorRequirements</example>
        [DataMember(Name = "processorRequirements")]
        public Text ProcessorRequirements { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        /// <example>https://schema.org/releaseNotes</example>
        [DataMember(Name = "releaseNotes")]
        public TextRef ReleaseNotes { get; set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        /// <example>https://schema.org/screenshot</example>
        [DataMember(Name = "screenshot")]
        public ImageObjectRef Screenshot { get; set; }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        /// <example>https://schema.org/softwareAddOn</example>
        [DataMember(Name = "softwareAddOn")]
        public SoftwareApplication SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        /// <example>https://schema.org/softwareHelp</example>
        [DataMember(Name = "softwareHelp")]
        public CreativeWork SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes 
        /// runtime environments and shared libraries that are not included in 
        /// the application distribution package, but required to run the 
        /// application (Examples: DirectX, Java or .NET runtime). 
        /// </summary>
        /// <example>https://schema.org/softwareRequirements</example>
        [DataMember(Name = "softwareRequirements")]
        public TextRef SoftwareRequirements { get; set; }

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        /// <example>https://schema.org/softwareVersion</example>
        [DataMember(Name = "softwareVersion")]
        public Text SoftwareVersion { get; set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        /// <example>https://schema.org/storageRequirements</example>
        [DataMember(Name = "storageRequirements")]
        public TextRef StorageRequirements { get; set; }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        /// <example>https://schema.org/supportingData</example>
        [DataMember(Name = "supportingData")]
        public DataFeed SupportingData { get; set; }
    }
}
