using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in centimetres
    /// </summary>
    class DistanceCentimetre : Distance
    {
        /// <summary>
        /// The amount to multiply this distance by to convert it to metres.
        /// </summary>
        public override double ValueToMetresRatio => 0.01;

        /// <summary>
        /// The name of this distance unit.
        /// </summary>
        public override string Name => "Centimetre";

        /// <summary>
        /// The abbreviated name of this distance unit.
        /// </summary>
        public override string Abbreviation => "cm";
    }
}
