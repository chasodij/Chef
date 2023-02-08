namespace chef.BLL.Entities
{
    public class OrderItem
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public int OrderId { get; set; }
        public int Portions { get; set; }
    }
}
