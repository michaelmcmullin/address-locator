﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in miles
    /// </summary>
    class DistanceMile : Distance
    {
        /// <summary>
        /// The amount to multiply this distance by to convert it to metres.
        /// </summary>
        public override double ValueToMetresRatio => 1609.344;

        /// <summary>
        /// The name of this distance unit.
        /// </summary>
        public override string Name => "Mile";

        /// <summary>
        /// The abbreviated name of this distance unit.
        /// </summary>
        public override string Abbreviation => "mi";
    }
}
