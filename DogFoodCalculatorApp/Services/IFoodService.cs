using System;
using System.Collections.Generic;
using DogFoodCalculatorApp.Services.Data;

namespace DogFoodCalculatorApp.Services
{
    public interface IFoodService
    {
        public IList<IFoodItem> CalculateFoodAmount(int percentage, double weight);

        public Tuple<int, int> ConvertToImperial(double weight);
    }
}