using System;
using AddressLocator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class DistanceNameTests
    {
        [TestMethod, TestCategory("Distance Names")]
        public void DistanceCentimetres_GetNames()
        {
            DistanceCentimetres distance = new DistanceCentimetres();
            Assert.AreEqual("Centimetre", distance.Name);
            Assert.AreEqual("Centimetres", distance.Plural);
            Assert.AreEqual("cm", distance.Abbreviation);
        }

        [TestMethod, TestCategory("Distance Names")]
        public void DistanceFeet_GetNames()
        {
            DistanceFeet distance = new DistanceFeet();
            Assert.AreEqual("Foot", distance.Name);
            Assert.AreEqual("Feet", distance.Plural);
            Assert.AreEqual("ft", distance.Abbreviation);
        }

        [TestMethod, TestCategory("Distance Names")]
        public void DistanceKilometres_GetNames()
        {
            DistanceKilometres distance = new DistanceKilometres();
            Assert.AreEqual("Kilometre", distance.Name);
            Assert.AreEqual("Kilometres", distance.Plural);
            Assert.AreEqual("km", distance.Abbreviation);
        }

        [TestMethod, TestCategory("Distance Names")]
        public void DistanceMetres_GetNames()
        {
            DistanceMetres distance = new DistanceMetres();
            Assert.AreEqual("Metre", distance.Name);
            Assert.AreEqual("Metres", distance.Plural);
            Assert.AreEqual("m", distance.Abbreviation);
        }

        [TestMethod, TestCategory("Distance Names")]
        public void DistanceMiles_GetNames()
        {
            DistanceMiles distance = new DistanceMiles();
            Assert.AreEqual("Mile", distance.Name);
            Assert.AreEqual("Miles", distance.Plural);
            Assert.AreEqual("mi", distance.Abbreviation);
        }

        [TestMethod, TestCategory("Distance Names")]
        public void DistanceNauticalMiles_GetNames()
        {
            DistanceNauticalMiles distance = new DistanceNauticalMiles();
            Assert.AreEqual("Nautical Mile", distance.Name);
            Assert.AreEqual("Nautical Miles", distance.Plural);
            Assert.AreEqual("nmi", distance.Abbreviation);
        }

        [TestMethod, TestCategory("Distance Names")]
        public void DistanceYards_GetNames()
        {
            DistanceYards distance = new DistanceYards();
            Assert.AreEqual("Yard", distance.Name);
            Assert.AreEqual("Yards", distance.Plural);
            Assert.AreEqual("yd", distance.Abbreviation);
        }

    }
}
