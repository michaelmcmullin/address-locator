using System;
using AddressLocator;
using AddressLocator.Repositories;
using AddressLocator.Locators;

namespace TestOpenStreetMap
{
    class Program
    {
        /// <summary>
        /// Update this email address to your correct email address to play
        /// nicely with OpenStreetMap.
        /// </summary>
        static string email = "example@example.com";

        static void Main(string[] args)
        {
            AddressFormatterRepository addressFormatters = new AddressFormatterRepository();
            CountryRepository countries = new CountryRepository(addressFormatters);

            Country ireland = countries.GetByName("Ireland");
            Address address = new Address(ireland.AddressSingleLineFormat);

            address.Address1 = "Microsoft Ireland";
            address.Address2 = "Sandyford Industrial Estate";
            address.City = "Sandyford";
            address.Region = "Dublin 18";
            address.Country = ireland;

            Console.WriteLine(address);

            OpenStreetMap osm = new OpenStreetMap(address, email);
            Location location = osm.GetCoordinates();

            Console.WriteLine(location != null ? location.ToString() : "Can't find co-ordinates");

            Console.Write("\nPress Enter to quit");
            Console.ReadLine();
        }
    }
}