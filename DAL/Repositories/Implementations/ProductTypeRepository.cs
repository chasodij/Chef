using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public bool Update(ProductType entity)
        {
            throw new NotImplementedException();
        }
    }
}
