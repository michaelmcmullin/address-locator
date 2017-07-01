using System;
using AddressLocator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class DistanceConstructorTests
    {
        const double Tolerance = 0.000001;

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
    }
}
