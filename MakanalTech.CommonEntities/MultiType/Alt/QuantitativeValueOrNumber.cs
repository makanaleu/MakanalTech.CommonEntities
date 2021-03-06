﻿using MakanalTech.CommonEntities.Core.Intangible.StructuredValue;
using MakanalTech.CommonEntities.DataType;
using System.Runtime.Serialization;

namespace MakanalTech.CommonEntities.MultiType.Alt
{
    /// <summary>
    /// QuantitativeValueOrNumber MultiType accepts QuantitativeValue or Number.
    /// </summary>
    [DataContract(Name = "QuantitativeValueOrNumber", Namespace = "CommonEntities.MultiType.Alt")]
    public class QuantitativeValueOrNumber : Number
    {
        /// <summary>
        /// QuantitativeValueOrNumber as a QuantitativeValue.
        /// </summary>
        [DataMember(Name = "asQuantitativeValue")]
        public QuantitativeValue AsQuantitativeValue { get; set; }

        /// <summary>
        /// QuantitativeValueOrNumber as a QuantitativeValue.
        /// </summary>
        /// <param name="quantitativeValue">QuantitativeValueOrNumber as a QuantitativeValue.</param>
        public QuantitativeValueOrNumber(QuantitativeValue quantitativeValue)
            : base(quantitativeValue.Value)
        {
            AsQuantitativeValue = quantitativeValue;
        }

        /// <summary>
        /// QuantitativeValueOrNumber as a QuantitativeValue.
        /// </summary>
        /// <param name="number">QuantitativeValueOrNumber as a QuantitativeValue.</param>
        public QuantitativeValueOrNumber(Number number) : base(number.AsText) { }

        /// <summary>
        /// QuantitativeValueOrNumber.
        /// </summary>
        public QuantitativeValueOrNumber() : base() { }
    }
}
