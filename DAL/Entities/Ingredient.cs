namespace chef.BLL.Entities
{
    public class Ingredient
    {
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int DishId { get; set; }
        public string DishName { get; set; }
        public double AmountInUnits { get; set; }
        public string UnitsOfMeasurement { get; set; }
    }
}
