using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in yards
    /// </summary>
    class DistanceYard : Distance
    {
        /// <summary>
        /// The amount to multiply this distance by to convert it to metres.
        /// </summary>
        public override double ValueToMetresRatio => 0.9144;

        /// <summary>
        /// The name of this distance unit.
        /// </summary>
        public override string Name => "Yard";

        /// <summary>
        /// The abbreviated name of this distance unit.
        /// </summary>
        public override string Abbreviation => "yd";
    }
}
