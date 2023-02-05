using chef.BLL.Entities;
using chef.BLL.Repositories;
using chef.BLL.Repositories.Interfaces;

namespace chef.DAL.Repositories.Interfaces
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
        bool IsExistWithDishId(int id);
    }
}
