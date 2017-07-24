using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AddressLocator.Locators
{
    /// <summary>
    /// A service for finding the latitude and longitude of an address through
    /// OpenStreetMap Nominatim tool.
    /// </summary>
    public class OpenStreetMap : IAddressLocator
    {
        /// <summary>
        /// Constructor that requires an email address to be included.
        /// </summary>
        /// <param name="email">The email address of the person making a call to
        /// the OpenStreetMap Nominatim tool.</param>
        public OpenStreetMap(Address address, string email)
        {
            this.Address = address;
            this.Email = email;
        }

        /// <summary>
        /// The address to locate.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Base URL of the Nominatim tool.
        /// </summary>
        protected string BaseUrl => "http://nominatim.openstreetmap.org/search?";

        /// <summary>
        /// The email address of the person making a call to the OpenStreetMap
        /// Nominatim tool.
        /// </summary>
        protected string Email { get; set; }

        /// <summary>
        /// Time in milliseconds between each request.
        /// </summary>
        protected int TimeBetweenRequests => 2000;

        /// <summary>
        /// Given an address string, check to see if a cached version exists to
        /// save running an expensive call to a third party service.
        /// </summary>
        /// <param name="address">A formatted address string.</param>
        /// <returns>A populated Location, or null if the address is not
        /// available in the cache.</returns>
        public Location CachedLocation(string address)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempt to resolve an address location in terms of latitude/
        /// longitude.
        /// </summary>
        /// <returns>A populated Location, or null if the address cannot be
        /// found.</returns>
        public Location GetCoordinates()
        {
            return FindLocation(Address.ToString());
        }

        /// <summary>
        /// Given a formatted address string, attempt to resolve its location in
        /// terms of latitude/longitude.
        /// </summary>
        /// <param name="address">A formatted address string.</param>
        /// <returns></returns>
        protected Location FindLocation(string address)
        {
            if (address == null || address == String.Empty)
            {
                return null;
            }

            // TODO: Check cached addresses.

            // Construct query
            StringBuilder query = new StringBuilder();
            query.Append(BaseUrl);
            query.Append("q=");
            query.Append(WebUtility.UrlEncode(address));
            query.Append("&limit=1&format=json&email=");
            query.Append(Email);

            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(query.ToString()).Result;
            if (response.Length > "[]".Length)
            {
                JObject o = JObject.Parse(response.Trim("[]".ToCharArray()));
                if (o.Count > 1)
                {
                    double lat = (double)o["lat"];
                    double lon = (double)o["lon"];
                    return new Location(lat, lon);
                }
            }

            Task.Delay(TimeBetweenRequests).Wait();
            return FindLocation(Address.Formatter.RemoveStart(address));
        }
    }
}
