using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator.Mocks
{
    /// <summary>
    /// A mock service for finding the latitude and longitude of an address.
    /// </summary>
    public class Locator : IAddressLocator
    {
        /// <summary>
        /// Given a formatted address string, attempt to resolve its location in
        /// terms of latitude/longitude.
        /// </summary>
        /// <param name="address">A formatted address string.</param>
        /// <returns>A populated Location, although with a fake latitude/
        /// longitude value (0,0)</returns>
        public Location GetCoordinates(string address)
        {
            return new Location(0, 0);
        }
    }
}
