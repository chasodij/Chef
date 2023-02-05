using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

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

        public IEnumerable<Ingredient> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Ingredient entity)
        {
            throw new NotImplementedException();
        }
    }
}
