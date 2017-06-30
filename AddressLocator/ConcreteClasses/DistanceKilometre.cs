using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in kilometers
    /// </summary>
    class DistanceKilometre : Distance
    {
        /// <summary>
        /// The amount to multiply this distance by to convert it to metres.
        /// </summary>
        public override double ValueToMetresRatio => 1000;

        /// <summary>
        /// The name of this distance unit.
        /// </summary>
        public override string Name => "Kilometre";

        /// <summary>
        /// The abbreviated name of this distance unit.
        /// </summary>
        public override string Abbreviation => "km";
    }
}
