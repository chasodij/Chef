namespace chef.BLL.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Portions { get; set; }
        public int CookingTimeInMinutes { get; set; }
        public int Weight { get; set; }
        public string Recipe { get; set; }
        public string MenuSection { get; set; }
        public decimal Price { get; set; }
        public string EnergyCategory { get; set; }
    }
}
