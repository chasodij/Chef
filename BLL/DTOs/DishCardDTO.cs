using System.Collections.Generic;

namespace chef.BLL.DTOs
{
    public class DishCardDTO
    {
        public string DishName { get; set; }
        public int Weight { get; set; }
        public double TotalProteinsInGrams { get; set; }
        public double TotalFatsInGrams { get; set; }
        public double TotalCarbohydratesInGrams { get; set; }
        public double TotalCalories { get; set; }
        public List<IngredientInDishCardDTO> Ingredients { get; set; }
    }
}
