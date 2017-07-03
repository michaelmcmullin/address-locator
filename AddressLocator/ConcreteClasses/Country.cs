using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Class that handles Country data.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// The name of this country instance.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ISO-3166 code for this country instance.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Recommended format for this country's addresses on a single line.
        /// </summary>
        public IAddressFormatter AddressSingleLineFormat { get; set; }

        /// <summary>
        /// String representation of this country.
        /// </summary>
        /// <returns>The name of this country as a string.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
