﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in yards
    /// </summary>
    public class DistanceYards : Distance
    {
        /// <summary>
        /// Default constructor, initialises the Value to zero.
        /// </summary>
        public DistanceYards() : base() { }

        /// <summary>
        /// Constructor that sets a distance Value.
        /// </summary>
        /// <param name="value">The value to initialise this distance to.
        /// </param>
        public DistanceYards(double value) : base(value) { }

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