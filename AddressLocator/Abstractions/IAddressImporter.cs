using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Interface for importing an address from one format into a format that's
    /// compatible with an Address object.
    /// </summary>
    /// <typeparam name="T">The format containing the original address.
    /// </typeparam>
    interface IAddressImporter<T>
    {
        /// <summary>
        /// Imports an address from a custom format into an
        /// AddressLocator.Address format.
        /// </summary>
        /// <param name="address">The original custom address to import.</param>
        /// <returns>A populated Address object.</returns>
        Address Import(T address);
    }
}
