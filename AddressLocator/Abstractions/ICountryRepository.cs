using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Repository for retrieving Country data.
    /// </summary>
    public interface ICountryRepository
    {
        /// <summary>
        /// Gets a Country instance based on its name.
        /// </summary>
        /// <param name="name">The name of the country to fetch.</param>
        /// <returns>A populated Country instance, or null.</returns>
        Country GetByName(string name);
    }
}
