using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Basket.Services.Models;
using Basket.Services.Services.Interfaces;

namespace Basket.Services
{
    public class BasketService
    {
        private ICalculatorService _calculatorService;

        public BasketService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public decimal GetTotal(BasketModel basket)
        {
            throw new NotImplementedException();
        }
    }
}