using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Repository for retrieving Country data.
    /// </summary>
    public class CountryRepository : ICountryRepository
    {
        /// <summary>
        /// Repository to store country data.
        /// </summary>
        private static Dictionary<string, Country> countries;

        /// <summary>
        /// Used to prevent two threads accessing countries simultaneously
        /// while it's being populated.
        /// </summary>
        private Object countryLock = new Object();

        /// <summary>
        /// Constructor that populates countries if it hasn't already been done.
        /// </summary>
        public CountryRepository()
        {
            if (countries == null || countries.Count == 0)
            {
                PopulateCountries();
            }
        }

        /// <summary>
        /// Gets a Country instance based on its name.
        /// </summary>
        /// <param name="name">The name of the country to fetch.</param>
        /// <returns>A populated Country instance, or null.</returns>
        public Country GetByName(string name)
        {
            return countries[name];
        }

        /// <summary>
        /// Method to populate the countries dictionary.
        /// </summary>
        protected void PopulateCountries()
        {
            lock(countryLock)
            {
                FormatterRepository formatters = new FormatterRepository();

                if (countries == null)
                {
                    countries = new Dictionary<string, Country>(StringComparer.OrdinalIgnoreCase);
                }
                countries.Add("Ireland", new Country { Name = "Ireland", Code = "IE", AddressSingleLineFormat = formatters.Get("Generic") });
            }
        }
    }
}
