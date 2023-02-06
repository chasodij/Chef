using chef.BLL.Entities;
using System.Collections.Generic;

namespace chef.BLL.Services
{
    public interface IDishService
    {
        void GetMaxValues(out int maxPortions, out int maxTime, out int maxWeight, out float maxPrice);
        IEnumerable<Dish> GetDishesByName(string name);
        Dish GetDishById(int id);
        void DeleteDish(int id);
        (bool canDelete, string error) CanDeleteDish(Dish dish);
    }
}
