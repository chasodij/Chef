using System;

namespace chef.BLL.Entities
{
    public class Special
    {
        public int Id { get; set; }
        public int DishId { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
