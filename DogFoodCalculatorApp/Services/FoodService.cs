using System;
using System.Collections.Generic;
using DogFoodCalculatorApp.Services.Data;

namespace DogFoodCalculatorApp.Services
{
    public class FoodService : IFoodService
    {
        public IList<IFoodItem> CalculateFoodAmount(int percentage, double weight)
        {
            var totalAmount = (double) percentage / 100 * weight * 1000;
            var foodList = new List<IFoodItem>
            {
                CreateFoodItem(totalAmount, "Protein", 80),
                CreateFoodItem(totalAmount, "Offal", 10),
                CreateFoodItem(totalAmount, "Bone", 10)
            };

            return foodList;
        }

        public Tuple<int, int> ConvertToImperial(double weight)
        {
            throw new NotImplementedException();
        }

        private static IFoodItem CreateFoodItem(double totalAmount, string description, int percentage)
        {
            var itemAmount = (double) percentage / 100 * totalAmount;
            return new FoodItem
            {
                Amount = (int) itemAmount,
                Description = description,
                DisplayAmount = $"{itemAmount}g",
                Percentage = percentage
            };
        }
    }
}