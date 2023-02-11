using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace chef.DAL.Repositories.Implementations
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductTypeRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(ProductType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductType> GetAll(List<string> searchStatements = null, List<string> sortStatements = null)
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT type_id, type_name, proteins, " +
                    "fats, carbohydrates, energy_value, units_of_measurement FROM types_of_products";

                using (IDataReader reader = cmd.ExecuteReader())
                {
                    var productTypes = new List<ProductType>();

                    while (reader.Read())
                    {
                        productTypes.Add(new ProductType
                        {
                            Id = (int)reader[0],
                            Name = (string)reader[1],
                            ProteinsPer100g = double.Parse(reader[2].ToString()),
                            FatsPer100g = double.Parse(reader[3].ToString()),
                            CarbohydratesPer100g = double.Parse(reader[4].ToString()),
                            CaloriesPer100g = double.Parse(reader[5].ToString()),
                            UnitsOfMeasurement = (string)reader[6]
                        });
                    }

                    return productTypes;
                }
            }
        }

        public string GetUnitsOfMeasurementByTypeId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductType entity)
        {
            throw new NotImplementedException();
        }
    }
}
