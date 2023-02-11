using chef.BLL.Entities;
using chef.BLL.Repositories.Interfaces;

namespace chef.DAL.Repositories.Interfaces
{
    public interface IProductTypeRepository : IRepository<ProductType>
    {
        string GetUnitsOfMeasurementByTypeId(int id);
    }
}
