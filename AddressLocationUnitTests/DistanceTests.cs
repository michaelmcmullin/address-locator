using System;
using AddressLocator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class DistanceTests
    {
        const double Tolerance = 0.000001;

        [TestMethod, TestCategory("Distances")]
        public void Distance_SetMetres()
        {
            DistanceKilometres distance = new DistanceKilometres(1);
            distance.ValueInMetres = 10000;
            Assert.AreEqual(10, distance.Value, Tolerance);
        }
    }
}
