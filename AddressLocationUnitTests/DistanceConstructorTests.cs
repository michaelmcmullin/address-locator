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
            DistanceCentimetre distance = new DistanceCentimetre();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceCentimetres_DefaultConstructor_SpecifyValue()
        {
            DistanceCentimetre distance = new DistanceCentimetre(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(0.1, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_DefaultConstructor_ShouldBeZero()
        {
            DistanceFoot distance = new DistanceFoot();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceFeet_DefaultConstructor_SpecifyValue()
        {
            DistanceFoot distance = new DistanceFoot(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(3.048, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_DefaultConstructor_ShouldBeZero()
        {
            DistanceKilometre distance = new DistanceKilometre();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceKilometres_DefaultConstructor_SpecifyValue()
        {
            DistanceKilometre distance = new DistanceKilometre(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(10000, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_DefaultConstructor_ShouldBeZero()
        {
            DistanceMetre distance = new DistanceMetre();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMetres_DefaultConstructor_SpecifyValue()
        {
            DistanceMetre distance = new DistanceMetre(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(10, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_DefaultConstructor_ShouldBeZero()
        {
            DistanceMile distance = new DistanceMile();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceMiles_DefaultConstructor_SpecifyValue()
        {
            DistanceMile distance = new DistanceMile(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(16093.44, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_DefaultConstructor_ShouldBeZero()
        {
            DistanceNauticalMile distance = new DistanceNauticalMile();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceNauticalMiles_DefaultConstructor_SpecifyValue()
        {
            DistanceNauticalMile distance = new DistanceNauticalMile(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(18520, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_DefaultConstructor_ShouldBeZero()
        {
            DistanceYard distance = new DistanceYard();
            Assert.AreEqual(0, distance.Value, Tolerance);
            Assert.AreEqual(0, distance.ValueInMetres, Tolerance);
        }

        [TestMethod, TestCategory("Distance Constructors")]
        public void DistanceYards_DefaultConstructor_SpecifyValue()
        {
            DistanceYard distance = new DistanceYard(10);
            Assert.AreEqual(10, distance.Value, Tolerance);
            Assert.AreEqual(9.144, distance.ValueInMetres, Tolerance);
        }
    }
}
