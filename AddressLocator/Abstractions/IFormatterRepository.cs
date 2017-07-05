using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Repository for retrieving AddressFormatter data.
    /// </summary>
    interface IFormatterRepository
    {
        /// <summary>
        /// Gets a named AddressFormatter from a repository instance.
        /// </summary>
        /// <param name="name">The name of the formatter to fetch.</param>
        /// <returns>A populated IAddressFormatter instance, or null.</returns>
        IAddressFormatter Get(string name);
    }
}
