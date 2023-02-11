using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Extensions;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chef.DAL.Repositories.Implementations
{
    public class DishRepository : IDishRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public DishRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Dish entity)
        {
            int dishId;

            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO dishes (dish_name, dish_portions, cooking_time, mass, recipe, menu_section, dish_price) " +
                "VALUES (@dish_name, @dish_portions, @cooking_time, @mass, @recipe, @menu_section, @dish_price) " +
                "SELECT SCOPE_IDENTITY();";

                cmd.AddParameterWithValue("@dish_name", entity.Name);
                cmd.AddParameterWithValue("@dish_portions", entity.Portions);
                cmd.AddParameterWithValue("@cooking_time", entity.CookingTimeInMinutes);
                cmd.AddParameterWithValue("@mass", entity.Weight);
                cmd.AddParameterWithValue("@recipe", entity.Recipe);
                cmd.AddParameterWithValue("@menu_section", entity.MenuSection);
                cmd.AddParameterWithValue("@dish_price", entity.Price);

                dishId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            UpdateDishIngredients(entity.Ingredients, dishId);

            DefineEnergyValueOfDish(dishId);
        }
        public void Update(Dish entity)
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "UPDATE dishes SET " +
                    "dish_name = @dish_name, dish_portions = @dish_portions, " +
                    "cooking_time = @cooking_time, mass = @mass, " +
                    "recipe = @recipe, menu_section = @menu_section, " +
                    "dish_price = @dish_price " +
                    "WHERE dish_id = @dish_id";

                cmd.AddParameterWithValue("@dish_name", entity.Name);
                cmd.AddParameterWithValue("@dish_portions", entity.Portions);
                cmd.AddParameterWithValue("@cooking_time", entity.CookingTimeInMinutes);
                cmd.AddParameterWithValue("@mass", entity.Weight);
                cmd.AddParameterWithValue("@recipe", entity.Recipe);
                cmd.AddParameterWithValue("@menu_section", entity.MenuSection);
                cmd.AddParameterWithValue("@dish_price", entity.Price);
            }

            UpdateDishIngredients(entity.Ingredients, entity.Id);

            DefineEnergyValueOfDish(entity.Id);
        }

        public void Delete(int id)
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM ingredients WHERE dish_id = @dish_id";
                cmd.AddParameterWithValue("@dish_id", id);
                cmd.ExecuteNonQuery();
            }

            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = $"DELETE FROM dishes WHERE dish_id = @dish_id";
                cmd.AddParameterWithValue("@dish_id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Dish> GetAll(List<string> filterStatements = null, List<string> sortStatements = null)
        {
            var text = new StringBuilder();
            text.Append("SELECT * FROM dishes");


            if (filterStatements != null)
            {
                filterStatements = filterStatements.Where(x => !x.Equals(string.Empty)).ToList();
                if (filterStatements.Count > 0)
                {
                    text.Append(" WHERE ");
                    text.Append(filterStatements[0]);

                    for (int i = 1; i < filterStatements.Count; i++)
                    {
                        text.Append(" AND ");
                        text.Append(filterStatements[i]);
                    }
                }
            }

            if (sortStatements != null)
            {
                sortStatements = sortStatements.Where(x => !x.Equals(string.Empty)).ToList();
                if (sortStatements.Count > 0)
                {
                    text.Append(" ORDER BY ");
                    text.Append(sortStatements[0]);

                    for (int i = 1; i < sortStatements.Count; i++)
                    {
                        text.Append(", ");
                        text.Append(sortStatements[i]);
                    }
                }
            }

            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = text.ToString();

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    var dishes = new List<Dish>();

                    while (reader.Read())
                    {
                        dishes.Add(new Dish
                        {
                            Id = (int)reader[0],
                            Name = (string)reader[1],
                            Portions = (int)reader[2],
                            CookingTimeInMinutes = (int)reader[3],
                            Weight = (int)reader[4],
                            Recipe = (string)reader[5],
                            MenuSection = (string)reader[6],
                            Price = decimal.Parse(reader[7].ToString()),
                            EnergyCategory = (string)reader[8]
                        });
                    }

                    return dishes;
                }
            }
        }

        public Dish GetById(int id)
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM dishes WHERE dish_id = @dish_id";

                cmd.AddParameterWithValue("@dish_id", id);

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader == null)
                    {
                        return new Dish();
                    }

                    return new Dish
                    {
                        Id = (int)reader[0],
                        Name = (string)reader[1],
                        Portions = (int)reader[2],
                        CookingTimeInMinutes = (int)reader[3],
                        Weight = (int)reader[4],
                        Recipe = (string)reader[5],
                        MenuSection = (string)reader[6],
                        Price = decimal.Parse(reader[7].ToString()),
                        EnergyCategory = (string)reader[8]
                    };
                }
            }
        }

        public (int maxPortions, int maxTime, int maxWeight, float maxPrice) GetMaxValues()
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(dish_portions), MAX(cooking_time), MAX(mass), MAX(dish_price) FROM dishes";

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader == null)
                    {
                        return (0, 0, 0, 0);
                    }

                    return ((int)reader[0], (int)reader[1], (int)reader[2], float.Parse(reader[3].ToString()));
                }
            }

        }

        private void UpdateDishIngredients(IEnumerable<Ingredient> ingredients, int dishId)
        {

            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM ingredients WHERE dish_id = @dish_id";

                cmd.AddParameterWithValue("@dish_id", dishId);

                cmd.ExecuteNonQuery();
            }

            foreach (var ingredient in ingredients)
            {
                using (var cmd = _unitOfWork.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO ingredients (type_id, dish_id, ingredient_amount) " +
                        "VALUES (@type_id, @dish_id, @ingredient_amount)";

                    cmd.AddParameterWithValue("@type_id", ingredient.ProductTypeId);
                    cmd.AddParameterWithValue("@dish_id", dishId);
                    cmd.AddParameterWithValue("@ingredient_amount", ingredient.AmountInUnits);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DefineEnergyValueOfDish(int dishId)
        {
            //Визначення енергетичної вартості страви
            double sum_energy_value = 0;
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT SUM(types_of_products.energy_value * ingredients.ingredient_amount)/dishes.dish_portions " +
                    "FROM types_of_products JOIN ingredients ON types_of_products.type_id = ingredients.type_id " +
                                           "JOIN dishes ON ingredients.dish_id = dishes.dish_id " +
                    "WHERE ingredients.dish_id = @dish_id " +
                    "GROUP BY dishes.dish_portions";

                cmd.AddParameterWithValue("@dish_id", dishId);

                sum_energy_value = Convert.ToDouble(cmd.ExecuteScalar());
            }

            //Додавання енергетичної категорії до страви
            string energy_category;
            if (sum_energy_value <= 200)
            {
                energy_category = "низька";
            }
            else if (sum_energy_value <= 500)
            {
                energy_category = "середня";
            }
            else
            {
                energy_category = "висока";
            }

            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "UPDATE dishes " +
                    "SET energy_category = @energy_category " +
                    "WHERE dish_id = @dish_id";

                cmd.AddParameterWithValue("@energy_category", energy_category);
                cmd.AddParameterWithValue("@dish_id", dishId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
