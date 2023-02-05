namespace chef.BLL.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ProteinsPer100g { get; set; }
        public double FatsPer100g { get; set; }
        public double CarbohydratesPer100g { get; set; }
        public double CaloriesPer100g { get; set; }
        public string UnitsOfMeasurement { get; set; }
    }
}
