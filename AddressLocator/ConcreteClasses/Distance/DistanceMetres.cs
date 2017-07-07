using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Stores distance values in metres
    /// </summary>
    public class DistanceMetres : Distance
    {
        /// <summary>
        /// Default constructor, initialises the Value to zero.
        /// </summary>
        public DistanceMetres() : base() { }

        /// <summary>
        /// Constructor that sets a distance Value.
        /// </summary>
        /// <param name="value">The value to initialise this distance to.
        /// </param>
        public DistanceMetres(double value) : base(value) { }

        /// <summary>
        /// Constructor that's based on another Distance instance.
        /// </summary>
        /// <param name="distance">The Distance object to create a new
        /// instance from.</param>
        public DistanceMetres(Distance distance) : base(distance) { }

        /// <summary>
        /// Constructor that sets a distance Value by measuring the distance
        /// between two locations.
        /// </summary>
        /// <param name="location1">Latitude and longitude of first location.
        /// </param>
        /// <param name="location2">Latitude and longitude of second location.
        /// </param>
        public DistanceMetres(Location location1, Location location2) :
            base(location1, location2)
        { }

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
