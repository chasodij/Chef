namespace chef.BLL.DTOs
{
    public class IngredientInDishCardDTO
    {
        public string Name { get; set; }
        public double AmountInUnits { get; set; }
        public string UnitsOfMeasurement { get; set; }
        public double ProteinsInGrams { get; set; }
        public double FatsInGrams { get; set; }
        public double CarbohydratesInGrams { get; set; }
        public double Calories { get; set; }
    }
}
