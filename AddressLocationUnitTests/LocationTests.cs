using System;
using AddressLocator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class LocationTests
    {
        const double Tolerance = 0.000001;

        [TestMethod, TestCategory("Location")]
        public void Location_Constructor_NormalPositiveInputs()
        {
            Location location = new Location(50.2, 11.6);
            Assert.AreEqual(50.2, location.Latitude, Tolerance);
            Assert.AreEqual(11.6, location.Longitude, Tolerance);
        }

        [TestMethod, TestCategory("Location")]
        public void Location_Constructor_NormalNegativeInputs()
        {
            Location location = new Location(-50.2, -11.6);
            Assert.AreEqual(-50.2, location.Latitude, Tolerance);
            Assert.AreEqual(-11.6, location.Longitude, Tolerance);
        }

        [TestMethod, TestCategory("Location")]
        public void Location_Constructor_OutOfBoundsPositiveInputs()
        {
            Location location = new Location(100.5, 200.6);
            Assert.AreEqual(10.5, location.Latitude, Tolerance);
            Assert.AreEqual(20.6, location.Longitude, Tolerance);
        }

        [TestMethod, TestCategory("Location")]
        public void Location_Constructor_OutOfBoundsNegativeInputs()
        {
            Location location = new Location(-100.5, -200.6);
            Assert.AreEqual(-10.5, location.Latitude, Tolerance);
            Assert.AreEqual(-20.6, location.Longitude, Tolerance);
        }

        [TestMethod, TestCategory("Location")]
        public void Location_Constructor_ExcessivelyOutOfBoundsPositiveInputs()
        {
            Location location = new Location(5387232.12, 18635118.7);
            Assert.AreEqual(12.12, location.Latitude, Tolerance);
            Assert.AreEqual(78.7, location.Longitude, Tolerance);
        }

        [TestMethod, TestCategory("Location")]
        public void Location_Constructor_ExcessivelyOutOfBoundsNegativeInputs()
        {
            Location location = new Location(-5387232.12, -18635118.7);
            Assert.AreEqual(-12.12, location.Latitude, Tolerance);
            Assert.AreEqual(-78.7, location.Longitude, Tolerance);
        }

    }
}
