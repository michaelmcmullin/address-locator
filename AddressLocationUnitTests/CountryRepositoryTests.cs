using System;
using AddressLocator;
using AddressLocator.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressLocationUnitTests
{
    [TestClass]
    public class CountryRepositoryTests
    {
        private ICountryRepository countries;
        private IAddressFormatterRepository formatters;


        [TestInitialize]
        public void CountryRepository_Initialiser()
        {
            formatters = new MockAddressFormatterRepository();
            countries = new MockCountryRepository(formatters);
        }

        [TestMethod, TestCategory("Repositories")]
        public void CountryRepository_GetExistingName()
        {
            Country country = countries.GetByName("Ireland");
            Assert.AreEqual(country.Name, "Ireland");
            Assert.AreEqual(country.Code, "IE");
        }

        [TestMethod, TestCategory("Repositories")]
        public void CountryRepository_GetNonExistingName()
        {
            Country country = countries.GetByName("Wonderland");
            Assert.IsNull(country);
        }
    }
}
