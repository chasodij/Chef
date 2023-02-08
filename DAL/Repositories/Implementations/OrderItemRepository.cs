using chef.BLL.Entities;
using chef.BLL.UnitOfWork;
using chef.DAL.Extensions;
using chef.DAL.Repositories.Interfaces;
using System.Collections.Generic;

namespace chef.DAL.Repositories.Implementations
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(OrderItem entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<OrderItem> GetAll(List<string> searchStatements = null, List<string> sortStatements = null)
        {
            throw new System.NotImplementedException();
        }

        public bool IsExistWithDishId(int id)
        {
            using (var cmd = _unitOfWork.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(dish_id) FROM order_items WHERE dish_id = @dish_id";

                cmd.AddParameterWithValue("@dish_id", id);

                var count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public bool Update(OrderItem entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
