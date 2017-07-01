using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in centimetres
    /// </summary>
    public class DistanceCentimetres : Distance
    {
        /// <summary>
        /// Default constructor, initialises the Value to zero.
        /// </summary>
        public DistanceCentimetres() : base() { }

        /// <summary>
        /// Constructor that sets a distance Value.
        /// </summary>
        /// <param name="value">The value to initialise this distance to.
        /// </param>
        public DistanceCentimetres(double value) : base(value) { }

        /// <summary>
        /// Constructor that's based on another Distance instance.
        /// </summary>
        /// <param name="distance">The Distance object to create a new
        /// instance from.</param>
        public DistanceCentimetres(Distance distance) : base(distance) { }

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
