using System;
using AddressLocator;
using AddressLocator.Repositories;
using AddressLocator.Locators;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;

namespace TestOpenStreetMap
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor defaultColour = Console.ForegroundColor;

            // Set up Dependency Injection
            var services = new ServiceCollection()
                .AddSingleton<IAddressFormatterRepository, AddressFormatterRepository>()
                .AddSingleton<ICountryRepository, CountryRepository>()
                .BuildServiceProvider();
            
            var countries = services.GetService<ICountryRepository>();

            // Set up the address details. 
            Country ireland = countries.GetByName("Ireland");
            Address address = new Address(ireland.AddressSingleLineFormat);
            address.Address1 = "Sandyford Industrial Estate";
            address.City = "Sandyford";
            address.Region = "Dublin 18";
            address.Country = ireland;

            // Here are some other locations for comparison
            Location dublin = new Location(53.3498, -6.2603);
            Location newyork = new Location(40.7128, -74.0059);

            // Get user's email address (required for OpenStreetMap API requests)
            string email;
            bool firstAttempt = true;
            do
            {
                if (!firstAttempt)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, invalid email address. Please try again.");
                    Console.ForegroundColor = defaultColour;
                }
                firstAttempt = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Please enter a valid email address: ");
                Console.ForegroundColor = defaultColour;
                email = Console.ReadLine();
            } while (!IsValidEmailAddress(email));

            Console.WriteLine("\nThank you! Now this demo will try and locate the following address:");
            Console.WriteLine(address);

            // Use OpenStreetMap API to try and find the address.
            OpenStreetMap osm = new OpenStreetMap(address, email);
            Location location = osm.GetCoordinates();

            if (location == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, can't find that location.");
                Console.ForegroundColor = defaultColour;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Success! Latitude/Longitude co-ordinates are:\n{location}");

                DistanceKilometres dublinDistance = new DistanceKilometres(dublin, location);
                DistanceKilometres newyorkDistance = new DistanceKilometres(newyork, location);
                dublinDistance.DecimalPlaces = newyorkDistance.DecimalPlaces = 0;

                Console.ForegroundColor = defaultColour;
                Console.WriteLine($"\nYou may be interested to know that this address is " +
                    $"{dublinDistance} from Dublin,\nand {newyorkDistance} from New York!");
            }

            Console.Write("\nPress Enter to quit");
            Console.ReadLine();
        }

        /// <summary>
        /// Method to verify if an email address is valid.
        /// </summary>
        /// <param name="email">The email address to check.</param>
        /// <returns>true if the email address is valid. Otherwise, false.
        /// </returns>
        /// <remarks>It's generally agreed that a universal fail-safe RegEx for
        /// email addresses either doesn't exist, or if it does, it might not be
        /// very useful. Therefore, </remarks>
        public static bool IsValidEmailAddress(string email)
        {
            if (email == null || email == String.Empty) return false;

            try
            {
                Regex emailRegex = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$", RegexOptions.IgnoreCase);
                return emailRegex.IsMatch(email);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}