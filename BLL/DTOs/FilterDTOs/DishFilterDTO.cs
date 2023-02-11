namespace chef.BLL.DTOs.FilterDTOs
{
    public class DishFilterDTO
    {
        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }
        public int MinCookingTime { get; set; }
        public int MaxCookingTime { get; set; }
        public int MinPortions { get; set; }
        public int MaxPortions { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
        public string MenuSection { get; set; }
        public string EnergyCategory { get; set; }
    }
}
