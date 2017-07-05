using System;
using System.Collections.Generic;
using System.Text;

namespace AddressLocator.Formatters
{
    public class Generic : IAddressFormatter
    {
        /// <summary>
        /// Given an Address instance, recreate it in a format that's suitable
        /// for further manipulation.
        /// </summary>
        /// <param name="address">The original address instance.</param>
        /// <returns>A formatted address ready for further processing.</returns>
        public string Format(Address address)
        {
            string output = $"{address.Address1},{address.Address2},{address.City},{address.Region},{address.Postcode},{address.Country}";
            while (output.IndexOf(",,") > -1)
            {
                output = output.Replace(",,", ",");
            }
            return output.Trim(", \n\r\t".ToCharArray());
        }

        /// <summary>
        /// Remove the first part of a given address, effectively making it less
        /// specific.
        /// </summary>
        /// <param name="address">A formatted address string.</param>
        /// <returns>A less-specific address string with the first part removed.
        /// </returns>
        /// <remarks>Some address lookup services may have trouble finding an
        /// address. By making the address less specific (e.g. removing the
        /// house number, the street name, etc), it has a better chance of
        /// finding something, albeit with less accuracy.</remarks>
        public string RemoveStart(string address)
        {
            int startIndex = address.IndexOf(',');
            return startIndex < 0 ?
                String.Empty :
                address.Substring(startIndex + 1);
        }
    }
}
