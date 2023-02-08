using System;

namespace chef.BLL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Time { get; set; }
        public bool IsCompleted { get; set; }
    }
}
