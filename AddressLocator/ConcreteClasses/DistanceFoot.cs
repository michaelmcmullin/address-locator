using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in feet
    /// </summary>
    class DistanceFoot : Distance
    {
        /// <summary>
        /// The amount to multiply this distance by to convert it to metres.
        /// </summary>
        public override double ValueToMetresRatio => 0.3048;

        /// <summary>
        /// The name of this distance unit.
        /// </summary>
        public override string Name => "Foot";

        /// <summary>
        /// The abbreviated name of this distance unit.
        /// </summary>
        public override string Abbreviation => "ft";
    }
}
