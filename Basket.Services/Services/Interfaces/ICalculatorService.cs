using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basket.Services.Models;

namespace Basket.Services.Services.Interfaces
{
    public interface ICalculatorService
    {
        decimal CalculateTotal(BasketModel basket);
    }
}
