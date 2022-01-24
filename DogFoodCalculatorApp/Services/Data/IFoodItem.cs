namespace DogFoodCalculatorApp.Services.Data
{
    public interface IFoodItem
    {
        public string Description { get; set; }

        public int Percentage { get; set; }

        public int Amount { get; set; }

        public string DisplayAmount { get; set; }
    }
}