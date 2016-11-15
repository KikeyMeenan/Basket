using System;
using System.Collections.Generic;
using Basket.Services;
using Basket.Services.Models;
using Basket.Services.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Basket.Tests
{
    [TestClass]
    public class BasketServiceTests
    {   
        private BasketModel _basket;
        private Mock<ICalculatorService> _calculatorServiceMock;

        private BasketService _service;

        [TestInitialize]
        public void Setup()
        {
            _basket = new BasketModel()
            {
                Products = new List<ProductModel>()
                {
                    new ProductModel()
                    {
                        Name = "Butter",
                        Price = .8M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Bread",
                        Price = 1M
                    }
                }
            };

            _calculatorServiceMock.Setup(o => o.CalculateTotal(It.IsAny<BasketModel>())).Returns(It.IsAny<decimal>());

            _service = new BasketService(_calculatorServiceMock.Object);
        }

        [TestCategory("BasketService"), TestMethod]
        public void Basket_ScenarioOne()
        {
            var result = _service.GetTotal(_basket);

            _calculatorServiceMock.Verify(o => o.CalculateTotal(_basket));

            Assert.IsNotNull(result);

            Assert.IsInstanceOfType(result, typeof(decimal));
        }
    }
}
