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
                cmd.CommandText = "SELECT types_of_products.type_name, " +
                                         "ingredients.ingredient_amount, " +
                                         "types_of_products.units_of_measurement " +
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
                            ProductTypeName = (string)reader[0],
                            AmountInUnits = double.Parse(reader[1].ToString()),
                            UnitsOfMeasurement = (string)reader[2]
                        });
                    }
                }

                return ingredients;
            }
        }

        public bool Update(Ingredient entity)
        {
            throw new NotImplementedException();
        }
    }
}
