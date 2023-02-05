using chef.BLL.Entities;
using chef.BLL.Repositories.Interfaces;

namespace chef.DAL.Repositories.Interfaces
{
    public interface ISpecialRepository : IRepository<Special>
    {
        bool IsExistWithDishId(int id);
    }
}
