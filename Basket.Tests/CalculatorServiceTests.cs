using System;
using System.Collections.Generic;
using Basket.Services;
using Basket.Services.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Basket.Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private BasketModel _basketOne;
        private BasketModel _basketTwo;
        private BasketModel _basketThree;
        private BasketModel _basketFour;

        private CalculatorService _service;

        [TestInitialize]
        public void Setup()
        {
            #region scenario one
            _basketOne = new BasketModel()
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
            #endregion

            #region scenario two
            _basketTwo = new BasketModel()
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
                        Name = "Butter",
                        Price = .8M
                    },
                    new ProductModel()
                    {
                        Name = "Bread",
                        Price = 1M
                    },
                    new ProductModel()
                    {
                        Name = "Bread",
                        Price = 1M
                    }
                }
            };
            #endregion

            #region scenario three
            _basketThree = new BasketModel()
            {
                Products = new List<ProductModel>()
                {
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    }
                }
            };
            #endregion

            #region scenario four
            _basketFour = new BasketModel()
            {
                Products = new List<ProductModel>()
                {
                    new ProductModel()
                    {
                        Name = "Butter",
                        Price = 0.8M
                    },
                    new ProductModel()
                    {
                        Name = "Butter",
                        Price = 0.8M
                    },
                    new ProductModel()
                    {
                        Name = "Bread",
                        Price = 1M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    },
                    new ProductModel()
                    {
                        Name = "Milk",
                        Price = 1.15M
                    }
                }
            };
            #endregion

            _service = new CalculatorService();
        }

        [TestCategory("CalculatorService"), TestMethod]
        public void Calculator_ScenarioOne()
        {
            var result = _service.CalculateTotal(_basketOne);

            Assert.IsTrue(result == 2.95M);
        }

        [TestCategory("CalculatorService"), TestMethod]
        public void Calculator_ScenarioTwo()
        {
            var result = _service.CalculateTotal(_basketTwo);

            Assert.IsTrue(result == 3.1M);
        }

        [TestCategory("CalculatorService"), TestMethod]
        public void Calculator_ScenarioThree()
        {
            var result = _service.CalculateTotal(_basketThree);

            Assert.IsTrue(result == 3.45M);
        }

        [TestCategory("CalculatorService"), TestMethod]
        public void Calculator_ScenarioFour()
        {
            var result = _service.CalculateTotal(_basketFour);

            Assert.IsTrue(result == 9M);
        }
    }
}
