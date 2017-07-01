using System;
using AddressLocator;
using AddressLocator.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class AddressFormatterTests
    {
        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Format_Address_With_Newlines()
        {
            Formatter formatter = new Formatter();
            string address = "1 Main Street\nKilcullen\nCo. Kildare\nIreland";
            string formattedAddress = formatter.Format(address);
            Assert.AreEqual("1 Main Street,Kilcullen,Co. Kildare,Ireland", formattedAddress);
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Remove_Start_Of_Address()
        {
            Formatter formatter = new Formatter();
            string address = "1 Main Street\nKilcullen\nCo. Kildare\nIreland";
            string formattedAddress = formatter.Format(address);
            Assert.AreEqual("Kilcullen,Co. Kildare,Ireland", formatter.RemoveStart(formattedAddress));
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Remove_Start_Of_Address_With_No_Separator()
        {
            Formatter formatter = new Formatter();
            string address = "Ireland";
            string formattedAddress = formatter.Format(address);
            Assert.AreEqual(String.Empty, formatter.RemoveStart(formattedAddress));
        }

        [TestMethod, TestCategory("Address Formatters")]
        public void AddressFormatter_Remove_Start_Of_Address_Empty_String()
        {
            Formatter formatter = new Formatter();
            string address = String.Empty;
            string formattedAddress = formatter.Format(address);
            Assert.AreEqual(String.Empty, formatter.RemoveStart(formattedAddress));
        }
    }
}