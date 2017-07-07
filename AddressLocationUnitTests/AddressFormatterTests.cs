using System;
using AddressLocator;
using AddressLocator.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class AddressFormatterTests
    {
        private IAddressFormatter formatter;
        private Address address;
        private Country ireland;

        [TestInitialize]
        public void AddressFormatter_Initialiser()
        {
            formatter = new AddressFormatter();
            address = new Address(formatter);
            ireland = new Country { Name = "Ireland", Code = "IE" };
            address.Address1 = "1 Main Street";
            address.City = "Kilcullen";
            address.Region = "Co. Kildare";
            address.Country = ireland;
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Format_Address()
        {
            string formattedAddress = formatter.Format(address);
            Assert.AreEqual("1 Main Street,Kilcullen,Co. Kildare,Ireland", formattedAddress);
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Format_Address_ToString()
        {
            Assert.AreEqual("1 Main Street,Kilcullen,Co. Kildare,Ireland", address.ToString());
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Remove_Start_Of_Address()
        {
            string formattedAddress = formatter.Format(address);
            Assert.AreEqual("Kilcullen,Co. Kildare,Ireland", formatter.RemoveStart(formattedAddress));
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Remove_Start_Of_Address_Country_Only()
        {
            Address countryOnly = new Address(formatter);
            countryOnly.Country = ireland;
            string formattedAddress = formatter.Format(countryOnly);
            Assert.AreEqual(String.Empty, formatter.RemoveStart(formattedAddress));
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Remove_Start_Of_Address_Empty_String()
        {
            Address emptyAddress = new Address(formatter);
            string formattedAddress = formatter.Format(emptyAddress);
            Assert.AreEqual(String.Empty, formatter.RemoveStart(formattedAddress));
        }
    }
}