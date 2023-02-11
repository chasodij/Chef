using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Extensions;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace chef.DAL.Repositories.Implementations
{
    public class SpecialRepository : ISpecialRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public SpecialRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Special entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Special> GetAll(List<string> searchStatements = null, List<string> sortStatements = null)
        {
            throw new NotImplementedException();
        }

        public bool IsExistWithDishId(int id)
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(dish_id) FROM specials WHERE dish_id = @dish_id";

                cmd.AddParameterWithValue("@dish_id", id);

                var count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public void Update(Special entity)
        {
            throw new NotImplementedException();
        }
    }
}
