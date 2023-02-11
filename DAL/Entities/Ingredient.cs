namespace chef.BLL.Entities
{
    public class Ingredient
    {
        public int ProductTypeId { get; set; }
        public int DishId { get; set; }
        public string DishName { get; set; }
        public double AmountInUnits { get; set; }
        public ProductType ProductType { get; set; }
    }
}
