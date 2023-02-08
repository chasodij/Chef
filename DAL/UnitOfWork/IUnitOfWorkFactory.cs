using chef.BLL.UnitOfWork;

namespace chef.DAL.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
