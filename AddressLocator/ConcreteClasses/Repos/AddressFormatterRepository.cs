using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator.Repositories
{
    /// <summary>
    /// Repository for retrieving AddressFormatter data.
    /// </summary>
    public class AddressFormatterRepository : IAddressFormatterRepository
    {
        /// <summary>
        /// Repository to store address formatters.
        /// </summary>
        private static Dictionary<string, IAddressFormatter> formatters;

        /// <summary>
        /// The default address formatter.
        /// </summary>
        private static IAddressFormatter defaultFormatter = new AddressFormatters.Generic();

        /// <summary>
        /// Used to prevent two threads accessing formatters simultaneously
        /// while it's being populated.
        /// </summary>
        private Object formatterLock = new Object();

        /// <summary>
        /// Constructor that populates formatters if it hasn't already been done.
        /// </summary>
        public AddressFormatterRepository()
        {
            if (formatters == null || formatters.Count == 0)
            {
                PopulateFormatters();
            }
        }

        /// <summary>
        /// Gets an IAddressFormatter instance based on its name.
        /// </summary>
        /// <param name="name">The name of the formatter to fetch.</param>
        /// <returns>A populated IAddressFormatter instance, or the default.</returns>
        public IAddressFormatter Get(string name)
        {
            if (formatters.ContainsKey(name))
            {
                return formatters[name];
            }
            return defaultFormatter;
        }

        /// <summary>
        /// Gets a default AddressFormatter from this repository.
        /// </summary>
        public IAddressFormatter Default
        {
            get { return defaultFormatter; }
        }

        /// <summary>
        /// Method to populate the countries dictionary.
        /// </summary>
        protected void PopulateFormatters()
        {
            lock (formatterLock)
            {
                if (formatters == null)
                {
                    formatters = new Dictionary<string, IAddressFormatter>(StringComparer.OrdinalIgnoreCase);
                }
                formatters.Add("Generic", defaultFormatter);
            }
        }
    }
}
