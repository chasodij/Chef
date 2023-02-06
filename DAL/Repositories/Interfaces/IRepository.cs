using System.Collections.Generic;

namespace chef.BLL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll(List<string> filterStatements = null, List<string> sortStatements = null);
        bool Update(T entity);
    }
}
