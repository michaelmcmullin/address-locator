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

        private readonly double latitudeRadians;
        private readonly double longitudeRadians;

        /// <summary>
        /// Constructor defining latitude and longitude.
        /// </summary>
        /// <param name="latitude">The latitude value to initialize this Location to.</param>
        /// <param name="longitude">The longitude value to initialize this Location to.</param>
        public Location(double latitude, double longitude)
        {
            this.latitude = latitude % 90;
            this.longitude = longitude % 180;

            this.latitudeRadians = this.latitude * Math.PI / 180.0;
            this.longitudeRadians = this.longitude * Math.PI / 180.0;
        }

        /// <summary>
        /// Gets the Latitude value of this Location (should be -90 to 90).
        /// </summary>
        public double Latitude { get { return latitude; } }

        /// <summary>
        /// Gets the Longitude value of this Location (should be -180 to 180).
        /// </summary>
        public double Longitude { get { return longitude; } }

        /// <summary>
        /// Gets the Latitude value of this Location in Radians.
        /// </summary>
        public double LatitudeRadians { get { return latitudeRadians; } }

        /// <summary>
        /// Gets the Longitude value of this Location in Radians.
        /// </summary>
        public double LongitudeRadians { get { return longitudeRadians; } }

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
