using chef.BLL.Entities;
using chef.DAL.UnitOfWork;
using Microsoft.Office.Interop.Word;
using System.Collections.Generic;

namespace chef.BLL.Services
{
    public class DishService : IDishService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public DishService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public IEnumerable<Dish> GetDishesByName(string name)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var dishes = uow.Dishes.GetAll(filterStatements:
                    new List<string> { $"dish_name LIKE '{name}%'" });

                return dishes;
            }
        }

        public Dish GetDishById(int id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var dish = uow.Dishes.GetById(id);
                dish.Ingredients = uow.Ingredients.GetAllByDishId(id);

                return dish;
            }
        }

        public void DeleteDish(int id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                uow.Dishes.Delete(id);

                uow.SaveChanges();
            }
        }

        public (bool canDelete, string error) CanDeleteDish(Dish dish)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var canDelete = !uow.OrderItems.IsExistWithDishId(dish.Id);

                if (!canDelete)
                {
                    return (false, $"Ви не можете видалити страву \"{dish.Name}\", бо вона присутня в замовленнях");
                }

                canDelete = !uow.Specials.IsExistWithDishId(dish.Id);

                if (!canDelete)
                {
                    return (false, $"Ви не можете видалити страву \"{dish.Name}\", бо її було обрано стравою дня");
                }

                return (true, string.Empty);
            }
        }

        public void GetMaxValues(out int maxPortions, out int maxTime, out int maxWeight, out float maxPrice)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var result = uow.Dishes.GetMaxValues();

                maxPortions = result.maxPortions;
                maxTime = result.maxTime;
                maxWeight = result.maxWeight;
                maxPrice = result.maxPrice;
            }
        }
    }
}
