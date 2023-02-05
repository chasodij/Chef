using System;

namespace chef.BLL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public double AmountInUnitsInStock { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
