using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Repositories.Interfaces;
using System.Collections.Generic;

namespace chef.DAL.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetAll(List<string> searchStatements = null, List<string> sortStatements = null)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
