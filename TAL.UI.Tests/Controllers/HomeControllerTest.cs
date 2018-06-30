using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TAL.PremiumCalculatorEngine;
using TAL.UI;
using TAL.UI.Controllers;

namespace TAL.UI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        private Mock<IPremiuimCalculatorEngine> _premiumCalculator;
        [TestInitialize]
        public void SetUpTests()
        {
            _premiumCalculator = new Mock<IPremiuimCalculatorEngine>();
            _premiumCalculator.Setup(m => m.CalculateCustomerPremium(It.IsAny<Customer>())).Returns(120);
          

        }

        [TestMethod]
        public void Index()
        {
            // Arrange
           
            HomeController controller = new HomeController(_premiumCalculator.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(_premiumCalculator.Object);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("TAL Digital Premium Calculator engine.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(_premiumCalculator.Object);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
