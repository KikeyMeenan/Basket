using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Basket.Services.Models;
using Basket.Services.Services.Interfaces;

namespace Basket.Services
{
    //THIS IS IN PLACE OF WHERE I WOULD USUALLY USE A CONTROLLER, I JUST DON'T HAVE THE TIME TO SET UP A FULL MVC PROJECT
    //THAT'S WHY THERE IS NO INTERFACE, BUT I DID DO IT TDD
    public class BasketService
    {
        private ICalculatorService _calculatorService;

        public BasketService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public decimal GetTotal(BasketModel basket)
        {
            return _calculatorService.CalculateTotal(basket);
        }
    }
}