using System;
using System.Collections.Concurrent;
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
        /// The address to locate.
        /// </summary>
        Address Address { get; set; }

        /// <summary>
        /// Given an address string, check to see if a cached version exists to
        /// save running an expensive call to a third party service.
        /// </summary>
        /// <param name="address">A formatted address string.</param>
        /// <returns>A populated Location, or null if the address is not
        /// available in the cache.</returns>
        Location CachedLocation(string address);

        /// <summary>
        /// Attempt to resolve an address location in terms of latitude/
        /// longitude.
        /// </summary>
        /// <returns>A populated Location, or null if the address cannot be
        /// found.</returns>
        Location GetCoordinates();
    }
}
