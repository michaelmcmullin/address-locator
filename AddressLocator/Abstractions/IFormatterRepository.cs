using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Repository for retrieving AddressFormatter data.
    /// </summary>
    public interface IFormatterRepository
    {
        /// <summary>
        /// Gets a named AddressFormatter from a repository instance.
        /// </summary>
        /// <param name="name">The name of the formatter to fetch.</param>
        /// <returns>A populated IAddressFormatter instance, or null.</returns>
        IAddressFormatter Get(string name);

        /// <summary>
        /// Gets a default AddressFormatter from a repository instance.
        /// </summary>
        IAddressFormatter Default { get; }
    }
}
