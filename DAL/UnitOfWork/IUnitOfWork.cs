using chef.DAL.Repositories.Interfaces;
using System;
using System.Data;

namespace chef.BLL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDishRepository Dishes { get; }
        IIngredientRepository Ingredients { get; }
        IOrderRepository Orders { get; }
        IOrderItemRepository OrderItems { get; }
        IProductRepository Products { get; }
        IProductTypeRepository ProductTypes { get; }
        ISpecialRepository Specials { get; }
        IUserRepository Users { get; }
        IDbCommand CreateCommand();
        void SaveChanges();
    }
}
