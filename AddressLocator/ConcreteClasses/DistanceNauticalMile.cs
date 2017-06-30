using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in nautical miles
    /// </summary>
    class DistanceNauticalMile : Distance
    {
        /// <summary>
        /// The amount to multiply this distance by to convert it to metres.
        /// </summary>
        public override double ValueToMetresRatio => 1852;

        /// <summary>
        /// The name of this distance unit.
        /// </summary>
        public override string Name => "Nautical Mile";

        /// <summary>
        /// The abbreviated name of this distance unit.
        /// </summary>
        public override string Abbreviation => "nmi";
    }
}
