using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.Health_Lifesci.Intangible.Enumeration
{
    /// <summary>
    /// Categories of physical activity, organized by physiologic classification.
    /// </summary>
    [DataContract(Name = "PhysicalActivityCategory", Namespace = "https://health-lifesci.schema.org/PhysicalActivityCategory")]
    public enum PhysicalActivityCategory
    {
        /// <summary>
        /// Physical activity of relatively low intensity that depends 
        /// primarily on the aerobic energy-generating process; during activity,
        /// the aerobic metabolism uses oxygen to adequately meet energy 
        /// demands during exercise.
        /// </summary>
        /// <example>https://health-lifesci.schema.org/AerobicActivity</example>
        [EnumMember(Value = "AerobicActivity")]
        AerobicActivity = 10,

        /// <summary>
        /// Physical activity that is of high-intensity which utilizes the 
        /// anaerobic metabolism of the body.
        /// </summary>
        /// <example>https://health-lifesci.schema.org/AnaerobicActivity</example>
        [EnumMember(Value = "AnaerobicActivity")]
        AnaerobicActivity = 20,

        /// <summary>
        /// Physical activity that is engaged to help maintain posture and 
        /// balance.
        /// </summary>
        /// <example>https://health-lifesci.schema.org/Balance</example>
        [EnumMember(Value = "Balance")]
        Balance = 30,

        /// <summary>
        /// Physical activity that is engaged in to improve joint and muscle 
        /// flexibility.
        /// </summary>
        /// <example>https://health-lifesci.schema.org/Flexibility</example>
        [EnumMember(Value = "Flexibility")]
        Flexibility = 40,

        /// <summary>
        /// Any physical activity engaged in for recreational purposes. Examples
        /// may include ballroom dancing, roller skating, canoeing, fishing, etc.
        /// </summary>
        /// <example>https://health-lifesci.schema.org/LeisureTimeActivity</example>
        [EnumMember(Value = "LeisureTimeActivity")]
        LeisureTimeActivity = 50,

        /// <summary>
        /// Any physical activity engaged in for job-related purposes. Examples
        /// may include waiting tables, maid service, carrying a mailbag, 
        /// picking fruits or vegetables,
        /// construction work, etc.
        /// </summary>
        /// <example>https://health-lifesci.schema.org/OccupationalActivity</example>
        [EnumMember(Value = "OccupationalActivity")]
        OccupationalActivity = 60,

        /// <summary>
        /// Physical activity that is engaged in to improve muscle and bone 
        /// strength. Also referred to as resistance training.
        /// </summary>
        /// <example>https://health-lifesci.schema.org/StrengthTraining</example>
        [EnumMember(Value = "StrengthTraining")]
        StrengthTraining = 70,
    }
}
