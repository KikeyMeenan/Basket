using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Basket.Services.Services.Interfaces;
using Basket.Services.Models;

namespace Basket.Services
{
    public class CalculatorService : ICalculatorService
    {
        public decimal CalculateTotal(BasketModel basket)
        {
            decimal total = 0;

            try
            {
                if (basket?.Products != null)
                {
                    if (basket.Products.Count(x => x.Name.ToLower() == "butter") >= 2 && basket.Products.Any(x => x.Name.ToLower() == "bread"))
                    {
                        var firstBread = basket.Products.FirstOrDefault(x => x.Name.ToLower() == "bread");
                        firstBread.Price = firstBread.Price / 2;
                    }

                    if (basket.Products.Count(x => x.Name.ToLower() == "milk") >= 3)
                    {
                        var milksInBasket = basket.Products.Where(x => x.Name.ToLower() == "milk");
                        var freeMilks = milksInBasket.Count()/3;
                        for (int i = 0; i < freeMilks; i++)
                        {
                            milksInBasket.ElementAt(i).Price = 0M;
                        }
                    }

                    total = basket.Products.Sum(x => x.Price);
                }
            }
            catch (Exception)
            {
                //HANDLE EXCEPTION - MAYBE USE A SERVICE, IF NOT USING SOMETHING LIKE ELMAH 
                throw;
            }

            return total;
        }
    }
}