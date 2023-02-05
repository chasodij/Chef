using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Extensions;
using chef.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            int id;

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

                id = (int)cmd.ExecuteScalar();
            }

            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM ingredients WHERE dish_id = @dish_id";

                cmd.AddParameterWithValue("@dish_id", id);

                cmd.ExecuteNonQuery();
            }

            foreach (var ingredient in entity.Ingredients)
            {
                using (var cmd = _unitOfWork.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO ingredients (type_id, dish_id, ingredient_amount) " +
                        "VALUES (@type_id, @dish_id, @ingredient_amount)";

                    cmd.AddParameterWithValue("@type_id", ingredient.ProductTypeId);
                    cmd.AddParameterWithValue("@dish_id", ingredient.DishId);
                    cmd.AddParameterWithValue("@ingredient_amount", ingredient.AmountInUnits);

                    cmd.ExecuteNonQuery();
                }
            }

            //Визначення енергетичної вартості страви
            float sum_energy_value = 0;
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT SUM(types_of_products.energy_value * ingredients.ingredient_amount)/dishes.dish_portions " +
                    "FROM types_of_products JOIN ingredients ON types_of_products.type_id = ingredients.type_id " +
                                           "JOIN dishes ON ingredients.dish_id = dishes.dish_id " +
                    "WHERE ingredients.dish_id = @dish_id " +
                    "GROUP BY dishes.dish_portions";

                cmd.AddParameterWithValue("@dish_id", id);

                sum_energy_value = (int)cmd.ExecuteScalar();
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
                cmd.AddParameterWithValue("@dish_id", id);

                cmd.ExecuteNonQuery();
            }
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

        public IEnumerable<Dish> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Dish entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
