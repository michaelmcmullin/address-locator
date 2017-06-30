using System;
using AddressLocator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class DistanceConstructorTests
    {
        const double Tolerance = 0.000001;

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceCentimetres_DefaultConstructor_ShouldBeZero()
        {
            DistanceCentimetres distance = new DistanceCentimetres();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceCentimetres_DefaultConstructor_SpecifyValue()
        {
            DistanceCentimetres distance = new DistanceCentimetres(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(0.1, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_DefaultConstructor_ShouldBeZero()
        {
            DistanceFeet distance = new DistanceFeet();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_DefaultConstructor_SpecifyValue()
        {
            DistanceFeet distance = new DistanceFeet(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(3.048, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_DefaultConstructor_ShouldBeZero()
        {
            DistanceKilometres distance = new DistanceKilometres();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_DefaultConstructor_SpecifyValue()
        {
            DistanceKilometres distance = new DistanceKilometres(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(10000, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_DefaultConstructor_ShouldBeZero()
        {
            DistanceMetres distance = new DistanceMetres();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_DefaultConstructor_SpecifyValue()
        {
            DistanceMetres distance = new DistanceMetres(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(10, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_DefaultConstructor_ShouldBeZero()
        {
            DistanceMiles distance = new DistanceMiles();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_DefaultConstructor_SpecifyValue()
        {
            DistanceMiles distance = new DistanceMiles(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(16093.44, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_DefaultConstructor_ShouldBeZero()
        {
            DistanceNauticalMiles distance = new DistanceNauticalMiles();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_DefaultConstructor_SpecifyValue()
        {
            DistanceNauticalMiles distance = new DistanceNauticalMiles(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(18520, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_DefaultConstructor_ShouldBeZero()
        {
            DistanceYards distance = new DistanceYards();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_DefaultConstructor_SpecifyValue()
        {
            DistanceYards distance = new DistanceYards(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(9.144, distance.ValueInMetres, Tolerance);
        }
    }
}
