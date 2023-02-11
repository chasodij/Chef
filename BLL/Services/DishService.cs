using chef.BLL.DTOs;
using chef.BLL.Entities;
using chef.DAL.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace chef.BLL.Services
{
    public class DishService : IDishService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IMsWordService _msWordService;

        public DishService(IUnitOfWorkFactory unitOfWorkFactory, IMsWordService wordService)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            _msWordService = wordService;
        }

        public IEnumerable<Dish> GetDishes(List<string> filterStatements, List<string> sortStatements)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                return uow.Dishes.GetAll(filterStatements, sortStatements);
            }
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

        public DishCardDTO GetDishCardDataById(int id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var dish = uow.Dishes.GetById(id);
                dish.Ingredients = uow.Ingredients.GetAllByDishId(id);

                var dishCardDTO = new DishCardDTO
                {
                    DishName = dish.Name,
                    Weight = dish.Weight,
                    Ingredients = dish.Ingredients.Select(x => new IngredientInDishCardDTO
                    {
                        UnitsOfMeasurement = x.ProductType.UnitsOfMeasurement,
                        Name = x.ProductType.Name,
                        AmountInUnits = x.AmountInUnits,
                        ProteinsInGrams = x.ProductType.ProteinsPer100g * 10 * x.AmountInUnits,
                        FatsInGrams = x.ProductType.FatsPer100g * 10 * x.AmountInUnits,
                        CarbohydratesInGrams = x.ProductType.CarbohydratesPer100g * 10 * x.AmountInUnits,
                        Calories = x.ProductType.CaloriesPer100g * 10 * x.AmountInUnits
                    }).ToList(),
                    TotalProteinsInGrams = dish.Ingredients.Sum(x =>
                        x.ProductType.ProteinsPer100g * 10 * x.AmountInUnits),
                    TotalFatsInGrams = dish.Ingredients.Sum(x =>
                        x.ProductType.FatsPer100g * 10 * x.AmountInUnits),
                    TotalCarbohydratesInGrams = dish.Ingredients.Sum(x =>
                        x.ProductType.CarbohydratesPer100g * 10 * x.AmountInUnits),
                    TotalCalories = dish.Ingredients.Sum(x =>
                        x.ProductType.CaloriesPer100g * 10 * x.AmountInUnits)
                };

                return dishCardDTO;
            }
        }

        public void SaveDishCard(DishCardDTO dishCardDTO, string path)
        {
            _msWordService.CreateDishCardFile(dishCardDTO, path);
        }

        public void CreateDish(Dish dish)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                uow.Dishes.Create(dish);

                uow.SaveChanges();
            }
        }

        public void UpdateDish(Dish dish)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                uow.Dishes.Update(dish);

                uow.SaveChanges();
            }
        }

        public IEnumerable<ProductType> GetAllProductTypes()
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var productTypes = uow.ProductTypes.GetAll();

                return productTypes;
            }
        }
    }
}
