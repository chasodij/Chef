using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace chef.DAL.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll(List<string> searchStatements = null, List<string> sortStatements = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
