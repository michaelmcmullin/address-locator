using System;

namespace AddressLocator
{
    /// <summary>
    /// Latitude/Longitude co-ordinates of a location.
    /// </summary>
    public class Location
    {
        private readonly double latitude;
        private readonly double longitude;

        /// <summary>
        /// Constructor defining latitude and longitude.
        /// </summary>
        /// <param name="latitude">The latitude value to initialize this Location to.</param>
        /// <param name="longitude">The longitude value to initialize this Location to.</param>
        public Location(double latitude, double longitude)
        {
            this.latitude = latitude % 90;
            this.longitude = longitude % 180;
        }

        /// <summary>
        /// Gets the Latitude value of this Location.
        /// </summary>
        public double Latitude { get { return latitude; } }

        /// <summary>
        /// Gets the Longitude value of this Location.
        /// </summary>
        public double Longitude { get { return longitude; } }

        /// <summary>
        /// A string representation of this Location.
        /// </summary>
        /// <returns>A string formatted as 'latitude, longitude'.</returns>
        public override string ToString()
        {
            return $"{Latitude}, {Longitude}";
        }
    }
}
