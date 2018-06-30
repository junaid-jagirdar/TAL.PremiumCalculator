using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace TAL.PremiumCalculatorEngine.Tests
{
    [TestClass]
    public class PremiuimCalculatorEngineTests
    {
      
        
        [TestMethod]
        public void Should_Be_Zero_When_Age_Is_Less_Than_18()
        {
            var premiumCalculator = new PremiumCalculator();
            var customer = new Customer()
            {
                Gender = Gender.Male,
                Name = "",
                DateOfBirth = new DateTime(2018, 06, 28)
            };

            var premium = premiumCalculator.CalculateCustomerPremium(customer);
            premium.ShouldEqual(0);
                                        
        }

        [TestMethod]
        public void Should_Be_Zero_When_Age_Is_Greater_Than_65()
        {
            var premiumCalculator = new PremiumCalculator();
            var customer = new Customer()
            {
                Gender = Gender.Male,
                Name = "",
                DateOfBirth = new DateTime(1940, 06, 28)
            };

            var premium = premiumCalculator.CalculateCustomerPremium(customer);
            premium.ShouldEqual(0);

        }



        [TestMethod]
        public void Should_Be__120_When_Customer_Is_Male()
        {
            var premiumCalculator = new PremiumCalculator();
            var customer = new Customer()
            {
                Gender = Gender.Male,
                Name = "",
                DateOfBirth = new DateTime(1998, 07, 15)
            };

            var premium = premiumCalculator.CalculateCustomerPremium(customer);
            premium.ShouldEqual(120);

        }

        [TestMethod]
        public void Should_Be__110_When_Customer_Is_Female()
        {
            var premiumCalculator = new PremiumCalculator();
            var customer = new Customer()
            {
                Gender = Gender.Female,
                Name = "",
                DateOfBirth = new DateTime(1998, 07, 15)
            };

            var premium = premiumCalculator.CalculateCustomerPremium(customer);
            premium.ShouldEqual(110);

        }
    }
}
