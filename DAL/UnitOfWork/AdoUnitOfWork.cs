using chef.DAL.Repositories.Implementations;
using chef.DAL.Repositories.Interfaces;
using System;
using System.Data;

namespace chef.BLL.UnitOfWork
{
    public class AdoUnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        private IDishRepository _dishRepository;
        private IIngredientRepository _ingredientRepository;
        private IOrderRepository _orderRepository;
        private IOrderItemRepository _orderItemRepository;
        private IProductRepository _productRepository;
        private IProductTypeRepository _productTypeRepository;
        private ISpecialRepository _specialRepository;
        private IUserRepository _userRepository;

        public IDishRepository Dishes
        {
            get
            {
                if (_dishRepository == null)
                {
                    _dishRepository = new DishRepository(this);
                }
                return _dishRepository;
            }
        }

        public IOrderItemRepository OrderItems
        {
            get
            {
                if (_orderItemRepository == null)
                {
                    _orderItemRepository = new OrderItemRepository(this);
                }
                return _orderItemRepository;
            }
        }

        public IIngredientRepository Ingredients
        {
            get
            {
                if (_ingredientRepository == null)
                {
                    _ingredientRepository = new IngredientRepository(this);
                }
                return _ingredientRepository;
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(this);
                }
                return _orderRepository;
            }
        }

        public IProductRepository Products
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(this);
                }
                return _productRepository;
            }
        }

        public IProductTypeRepository ProductTypes
        {
            get
            {
                if (_productTypeRepository == null)
                {
                    _productTypeRepository = new ProductTypeRepository(this);
                }
                return _productTypeRepository;
            }
        }

        public ISpecialRepository Specials
        {
            get
            {
                if (_specialRepository == null)
                {
                    _specialRepository = new SpecialRepository(this);
                }
                return _specialRepository;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(this);
                }
                return _userRepository;
            }
        }

        public AdoUnitOfWork(IDbConnection connection)
        {
            _connection = connection;
            _transaction = _connection.BeginTransaction();
        }

        public IDbCommand CreateCommand()
        {
            var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            return cmd;
        }

        public void SaveChanges()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("Transaction have already been committed. Check your transaction handling.");
            }
            _transaction.Commit();
            _transaction = null;
        }
        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}
