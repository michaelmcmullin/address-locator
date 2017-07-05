using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Repository for retrieving AddressFormatter data.
    /// </summary>
    public class FormatterRepository : IFormatterRepository
    {
        /// <summary>
        /// Repository to store address formatters.
        /// </summary>
        private static Dictionary<string, IAddressFormatter> formatters;

        /// <summary>
        /// Used to prevent two threads accessing formatters simultaneously
        /// while it's being populated.
        /// </summary>
        private Object formatterLock = new Object();

        /// <summary>
        /// Constructor that populates formatters if it hasn't already been done.
        /// </summary>
        public FormatterRepository()
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
        /// <returns>A populated IAddressFormatter instance, or null.</returns>
        public IAddressFormatter Get(string name)
        {
            return formatters[name];
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
                formatters.Add("Generic", new Formatters.Generic());
            }
        }
    }
}
