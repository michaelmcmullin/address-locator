using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// A service for finding the latitude and longitude of a location.
    /// </summary>
    public interface IAddressLocator
    {
        /// <summary>
        /// Given a formatted address string, attempt to resolve its location in
        /// terms of latitude/longitude.
        /// </summary>
        /// <param name="address">A formatted address string.</param>
        /// <returns>A populated Location, or null if the address cannot be
        /// found.</returns>
        Location GetCoordinates(string address);
    }
}
