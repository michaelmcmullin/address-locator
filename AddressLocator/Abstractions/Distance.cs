using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// A base class to measure distances. Internally, it must resolve to metres
    /// so different types of Distance can be compared.
    /// </summary>
    public abstract class Distance : IComparer<Distance>, IComparable<Distance>
    {
        /// <summary>
        /// Default Distance constructor, initialises the Value to zero.
        /// </summary>
        protected Distance()
        {
            Value = 0;
        }

        /// <summary>
        /// Constructor that sets a distance Value.
        /// </summary>
        /// <param name="value">The value to initialise this distance to.
        /// </param>
        protected Distance(double value)
        {
            Value = value;
        }

        /// <summary>
        /// Constructor that sets a distance Value from another Distance
        /// instance.
        /// </summary>
        /// <param name="distance">The distance to use for initialising this
        /// distance instance.
        /// </param>
        protected Distance(Distance distance)
        {
            if (distance.ValueToMetresRatio == this.ValueToMetresRatio)
            {
                this.Value = distance.Value;
            }
            else
            {
                this.Value = distance.ValueInMetres / this.ValueToMetresRatio;
            }
        }

        /// <summary>
        /// The distance value using the specified units defined for the
        /// concrete implementation.
        /// </summary>
        private double value;

        /// <summary>
        /// The value which, when multiplied to the distance value, will give
        /// this distance in metres.
        /// </summary>
        public abstract double ValueToMetresRatio { get; }

        /// <summary>
        /// The name of this distance.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The plural name of this distance.
        /// </summary>
        public virtual string Plural { get { return Name + "s"; } }

        /// <summary>
        /// An abbreviation of this distance (useful for formatting strings).
        /// </summary>
        public abstract string Abbreviation { get; }

        /// <summary>
        /// The distance value using the specified units defined for the
        /// concrete implementation.
        /// </summary>
        public double Value { get { return value; } set { this.value = value; } }

        /// <summary>
        /// The distance value in metres.
        /// </summary>
        public double ValueInMetres
        {
            get { return Value * ValueToMetresRatio; }
            set { Value = value / ValueToMetresRatio; }
        }

        /// <summary>
        /// A value indicating how distance1 compares to distance2. Less than
        /// zero indicates that distance1 is less than distance2, while greater
        /// than zero indicates the opposite. Zero indicates that both distances
        /// are equal.
        /// </summary>
        public int Compare(Distance distance1, Distance distance2)
        {
            return distance1.ValueInMetres.CompareTo(distance2.ValueInMetres);
        }

        /// <summary>
        /// A value indicating how this instance compares to another distance.
        /// Less than zero indicates that it's less than the other distance,
        /// while greater than zero indicates the opposite. Zero indicates that
        /// both distances are equal.
        /// </summary>
        public int CompareTo(Distance other)
        {
            return Compare(this, other);
        }

        /// <summary>
        /// Converts this instance to a string.
        /// </summary>
        /// <returns>A string representation of this Distance.</returns>
        public override string ToString()
        {
            return $"{Value} {Abbreviation}";
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return ValueInMetres.GetHashCode();
        }
    }
}
