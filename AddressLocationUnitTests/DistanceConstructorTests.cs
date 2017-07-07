using System;
using AddressLocator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class DistanceConstructorTests
    {
        const double Tolerance = 0.000001;
        private Location dublin;
        private Location newyork;
        private double metresDublinToNewYork = 5114878.69864054;
        private double milesDublinToNewYork = 3178.23827512362;
        private double nauticalmilesDublinToNewYork = 2761.81355218172;
        private double feetDublinToNewYork = 16781098.0926527;

        [TestInitialize]
        public void DistanceConstructor_Initialiser()
        {
            dublin = new Location(53.3498, 6.2603);
            newyork = new Location(40.7128, 74.0059);
        }


        // DistanceCentimetres

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceCentimetres_DefaultConstructor_ShouldBeZero()
        {
            DistanceCentimetres distance = new DistanceCentimetres();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceCentimetres_Constructor_SpecifyValue()
        {
            DistanceCentimetres distance = new DistanceCentimetres(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(0.1, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceCentimetres_Constructor_FromAnotherDistance()
        {
            DistanceKilometres kmDistance = new DistanceKilometres(10);
            DistanceCentimetres cmDistance = new DistanceCentimetres(kmDistance);
            Assert.AreEqual(1000000, cmDistance.Value, Tolerance);
            Assert.AreEqual(10000, cmDistance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceCentimetres_Constructor_FromTwoLocations()
        {
            DistanceCentimetres cmDistance = new DistanceCentimetres(dublin, newyork);
            Assert.AreEqual(metresDublinToNewYork * 100, cmDistance.Value, Tolerance);
            Assert.AreEqual(metresDublinToNewYork, cmDistance.ValueInMetres, Tolerance);
        }

        // DistanceFeet

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_DefaultConstructor_ShouldBeZero()
        {
            DistanceFeet distance = new DistanceFeet();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_Constructor_SpecifyValue()
        {
            DistanceFeet distance = new DistanceFeet(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(3.048, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_Constructor_FromAnotherDistance()
        {
            DistanceKilometres kmDistance = new DistanceKilometres(10);
            DistanceFeet ftDistance = new DistanceFeet(kmDistance);
            Assert.AreEqual(32808.3989501312, ftDistance.Value, Tolerance);
            Assert.AreEqual(10000, ftDistance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_Constructor_FromTwoLocations()
        {
            DistanceFeet ftDistance = new DistanceFeet(dublin, newyork);
            Assert.AreEqual(feetDublinToNewYork, ftDistance.Value, Tolerance);
            Assert.AreEqual(metresDublinToNewYork, ftDistance.ValueInMetres, Tolerance);
        }

        // DistanceKilometres

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_DefaultConstructor_ShouldBeZero()
        {
            DistanceKilometres distance = new DistanceKilometres();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_Constructor_SpecifyValue()
        {
            DistanceKilometres distance = new DistanceKilometres(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(10000, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_Constructor_FromAnotherDistance()
        {
            DistanceKilometres kmDistance1 = new DistanceKilometres(10);
            DistanceKilometres kmDistance2 = new DistanceKilometres(kmDistance1);
            Assert.AreEqual(10, kmDistance2.Value, Tolerance);
            Assert.AreEqual(10000, kmDistance2.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_Constructor_FromTwoLocations()
        {
            DistanceKilometres kmDistance = new DistanceKilometres(dublin, newyork);
            Assert.AreEqual(metresDublinToNewYork / 1000, kmDistance.Value, Tolerance);
            Assert.AreEqual(metresDublinToNewYork, kmDistance.ValueInMetres, Tolerance);
        }

        // DistanceMetres

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_DefaultConstructor_ShouldBeZero()
        {
            DistanceMetres distance = new DistanceMetres();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_Constructor_SpecifyValue()
        {
            DistanceMetres distance = new DistanceMetres(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(10, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_Constructor_FromAnotherDistance()
        {
            DistanceKilometres kmDistance = new DistanceKilometres(10);
            DistanceMetres mDistance = new DistanceMetres(kmDistance);
            Assert.AreEqual(10000, mDistance.Value, Tolerance);
            Assert.AreEqual(10000, mDistance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_Constructor_FromTwoLocations()
        {
            DistanceMetres mDistance = new DistanceMetres(dublin, newyork);
            Assert.AreEqual(metresDublinToNewYork, mDistance.Value, Tolerance);
            Assert.AreEqual(metresDublinToNewYork, mDistance.ValueInMetres, Tolerance);
        }

        // DistanceMiles

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_DefaultConstructor_ShouldBeZero()
        {
            DistanceMiles distance = new DistanceMiles();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_Constructor_SpecifyValue()
        {
            DistanceMiles distance = new DistanceMiles(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(16093.44, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_Constructor_FromAnotherDistance()
        {
            DistanceKilometres kmDistance = new DistanceKilometres(10);
            DistanceMiles miDistance = new DistanceMiles(kmDistance);
            Assert.AreEqual(6.21371192237334, miDistance.Value, Tolerance);
            Assert.AreEqual(10000, miDistance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_Constructor_FromTwoLocations()
        {
            DistanceMiles miDistance = new DistanceMiles(dublin, newyork);
            Assert.AreEqual(milesDublinToNewYork, miDistance.Value, Tolerance);
            Assert.AreEqual(metresDublinToNewYork, miDistance.ValueInMetres, Tolerance);
        }

        // DistanceNauticalMiles

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_DefaultConstructor_ShouldBeZero()
        {
            DistanceNauticalMiles distance = new DistanceNauticalMiles();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_Constructor_SpecifyValue()
        {
            DistanceNauticalMiles distance = new DistanceNauticalMiles(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(18520, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_Constructor_FromAnotherDistance()
        {
            DistanceKilometres kmDistance = new DistanceKilometres(10);
            DistanceNauticalMiles nmiDistance = new DistanceNauticalMiles(kmDistance);
            Assert.AreEqual(5.39956803455724, nmiDistance.Value, Tolerance);
            Assert.AreEqual(10000, nmiDistance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_Constructor_FromTwoLocations()
        {
            DistanceNauticalMiles nmiDistance = new DistanceNauticalMiles(dublin, newyork);
            Assert.AreEqual(nauticalmilesDublinToNewYork, nmiDistance.Value, Tolerance);
            Assert.AreEqual(metresDublinToNewYork, nmiDistance.ValueInMetres, Tolerance);
        }

        // DistanceYards

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_DefaultConstructor_ShouldBeZero()
        {
            DistanceYards distance = new DistanceYards();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_Constructor_SpecifyValue()
        {
            DistanceYards distance = new DistanceYards(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(9.144, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_Constructor_FromAnotherDistance()
        {
            DistanceKilometres kmDistance = new DistanceKilometres(10);
            DistanceYards ydDistance = new DistanceYards(kmDistance);
            Assert.AreEqual(10936.1329833771, ydDistance.Value, Tolerance);
            Assert.AreEqual(10000, ydDistance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_Constructor_FromTwoLocations()
        {
            DistanceYards ydDistance = new DistanceYards(dublin, newyork);
            Assert.AreEqual(feetDublinToNewYork / 3, ydDistance.Value, Tolerance);
            Assert.AreEqual(metresDublinToNewYork, ydDistance.ValueInMetres, Tolerance);
        }
    }
}
