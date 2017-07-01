using System;
using AddressLocator;
using AddressLocator.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class AddressLocatorTests
    {
        [TestMethod, TestCategory("Address Locators")]
        public void AddressLocator_GetLocation()
        {
            Locator locator = new Locator();
            Location location = locator.GetCoordinates("Some Address");
            Assert.AreEqual(0, location.Latitude);
            Assert.AreEqual(0, location.Longitude);
        }
    }
}
