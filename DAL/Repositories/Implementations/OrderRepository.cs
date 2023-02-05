using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace chef.DAL.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
