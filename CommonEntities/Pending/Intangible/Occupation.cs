using CommonEntities.Core;
using CommonEntities.DataType;
using System.Runtime.Serialization;

namespace CommonEntities.Pending.Intangible
{
    /// <summary>
    /// A profession, may involve prolonged training and/or a formal 
    /// qualification.
    /// </summary>
    /// <remarks>
    /// The pending extension is a staging area for work-in-progress terms 
    /// which have yet to be accepted into the core vocabulary. Pending terms 
    /// are subject to change and should be used with caution.
    /// </remarks>
    [DataContract(Name = "Occupation", Namespace = "https://pending.schema.org/Occupation")]
    public class Occupation : Thing
    {
        /// <summary>
        /// Educational background needed for the position or Occupation.
        /// </summary>
        /// <example>https://pending.schema.org/educationRequirements</example>
        [DataMember(Name = "educationRequirements")]
        public Text EducationRequirements { get; set; }

        /// <summary>
        /// A property describing the estimated salary for a job posting based 
        /// on a variety of variables including, but not limited to industry, 
        /// job title, and location. The estimated salary is usually computed 
        /// by outside organizations and therefore the hiring organization is 
        /// not bound to this estimated salary.
        /// </summary>
        /// <example>https://pending.schema.org/estimatedSalary</example>
        [DataMember(Name = "estimatedSalary")]
        public Text EstimatedSalary { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position or 
        /// Occupation.
        /// </summary>
        /// <example>https://pending.schema.org/experienceRequirements</example>
        [DataMember(Name = "experienceRequirements")]
        public Text ExperienceRequirements { get; set; }

        /// <summary>
        /// The region/country for which this occupational description is 
        /// appropriate. Note that educational requirements and qualifications 
        /// can vary between jurisdictions.
        /// </summary>
        /// <example>https://pending.schema.org/occupationLocation</example>
        [DataMember(Name = "occupationLocation")]
        public AdministrativeArea OccupationLocation { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC 
        /// taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes
        /// textual label and formal code, with the property repeated for each
        /// applicable value.
        /// </summary>
        /// <example>https://pending.schema.org/occupationalCategory</example>
        [DataMember(Name = "occupationalCategory")]
        public Text OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role or Occupation.
        /// </summary>
        /// <example>https://pending.schema.org/qualifications</example>
        [DataMember(Name = "qualifications")]
        public Text Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role or Occupation.
        /// </summary>
        /// <example>https://pending.schema.org/responsibilities</example>
        [DataMember(Name = "responsibilities")]
        public Text Responsibilities { get; set; }

        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        /// <example>https://pending.schema.org/skills</example>
        [DataMember(Name = "skills")]
        public Text Skills { get; set; }
    }
}
