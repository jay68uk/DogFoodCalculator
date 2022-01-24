namespace DogFoodCalculatorApp.Services.Data
{
    public class FoodItem : IFoodItem
    {
        public string Description { get; set; }
        public int Percentage { get; set; }
        public int Amount { get; set; }
        public string DisplayAmount { get; set; }
    }
}