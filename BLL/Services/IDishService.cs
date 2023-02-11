using chef.BLL.DTOs;
using chef.BLL.Entities;
using System.Collections.Generic;

namespace chef.BLL.Services
{
    public interface IDishService
    {
        void CreateDish(Dish dish);
        void UpdateDish(Dish dish);
        void DeleteDish(int id);
        Dish GetDishById(int id);
        IEnumerable<Dish> GetDishes(List<string> filterStatements, List<string> sortStatements);
        IEnumerable<Dish> GetDishesByName(string name);
        IEnumerable<ProductType> GetAllProductTypes();
        DishCardDTO GetDishCardDataById(int id);
        void SaveDishCard(DishCardDTO dishCardDTO, string path);
        (bool canDelete, string error) CanDeleteDish(Dish dish);
        void GetMaxValues(out int maxPortions, out int maxTime, out int maxWeight, out float maxPrice);
    }
}
