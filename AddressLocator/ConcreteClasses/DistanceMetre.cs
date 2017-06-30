using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in metres
    /// </summary>
    class DistanceMetre : Distance
    {
        /// <summary>
        /// The amount to multiply this distance by to convert it to metres.
        /// </summary>
        public override double ValueToMetresRatio => 1;

        /// <summary>
        /// The name of this distance unit.
        /// </summary>
        public override string Name => "Metre";

        /// <summary>
        /// The abbreviated name of this distance unit.
        /// </summary>
        public override string Abbreviation => "m";
    }
}
