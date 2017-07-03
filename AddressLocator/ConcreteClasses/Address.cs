using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator
{
    /// <summary>
    /// Class that handles Address data.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// An address formatter to use for converting this address to a string.
        /// </summary>
        private IAddressFormatter Formatter;

        /// <summary>
        /// Constructor that initialises the formatter.
        /// </summary>
        /// <param name="formatter">The address formatter to use for converting
        /// this address to a string.</param>
        public Address(IAddressFormatter formatter)
        {
            Formatter = formatter;
        }
        
        /// <summary>
        /// First line of this address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of this address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// The city/town of this address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The region/state of this address.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// The postcode/zipcode of this address.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// The country of this address.
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Indicates whether or not this instance has Location data (i.e.
        /// latitude/longitide) set.
        /// </summary>
        public bool HasLocation { get { return Location != null; } }

        /// <summary>
        /// The latitude/longitude of this address.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// String representation of this address.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Formatter.Format(this);
        }
    }
}
