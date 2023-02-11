using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Extensions;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace chef.DAL.Repositories.Implementations
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public IngredientRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Ingredient entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredient> GetAll(List<string> searchStatements = null, List<string> sortStatements = null)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAllByDishId(int id)
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT " +
                                    "types_of_products.type_id, " +
                                    "types_of_products.type_name, " +
                                    "types_of_products.proteins, " +
                                    "types_of_products.fats, " +
                                    "types_of_products.carbohydrates, " +
                                    "types_of_products.energy_value, " +
                                    "types_of_products.units_of_measurement, " +
                                    "ingredients.ingredient_amount " +
                                "FROM types_of_products JOIN ingredients ON types_of_products.type_id = ingredients.type_id " +
                                "WHERE ingredients.dish_id = @dish_id";

                cmd.AddParameterWithValue("@dish_id", id);

                var ingredients = new List<Ingredient>();

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ingredients.Add(new Ingredient
                        {
                            ProductType = new ProductType
                            {
                                Id = (int)reader[0],
                                Name = (string)reader[1],
                                ProteinsPer100g = double.Parse(reader[2].ToString()),
                                FatsPer100g = double.Parse(reader[3].ToString()),
                                CarbohydratesPer100g = double.Parse(reader[4].ToString()),
                                CaloriesPer100g = double.Parse(reader[5].ToString()),
                                UnitsOfMeasurement = (string)reader[6],
                            },
                            AmountInUnits = double.Parse(reader[7].ToString())
                        });
                    }
                }

                return ingredients;
            }
        }

        public void Update(Ingredient entity)
        {
            throw new NotImplementedException();
        }
    }
}
